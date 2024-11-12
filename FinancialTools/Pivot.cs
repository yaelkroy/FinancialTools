
            .Select(rowGroup => new
            {
                Key = rowGroup.Key,
                Values = columns.GroupJoin(
                    rowGroup,
                    c => c,
                    r => columnSelector(r),
                    (c, columnGroup) => dataSelector(columnGroup))
            });

            foreach (var row in rows)
            {
                var dataRow = table.NewRow();
                var items = row.Values.Cast<object>().ToArray();
                dataRow[0] = row.Key;
                for (int i = 0; i < items.Length; i++)
                    dataRow[i + 1] = items[i];
                table.Rows.Add(dataRow);
            }

            return table;
        }
    }
}```csharp
                .Select(rowGroup => new
                             {
                                 Key = rowGroup.Key,
                                 Values = columns.GroupJoin(
                                     rowGroup,
                                     c => c,
                                     r => columnSelector(r),
                                     (c, columnGroup) => dataSelector(columnGroup))
                             });

            foreach (var row in rows)
            {
                var dataRow = table.NewRow();
                var items = row.Values.Cast<object>().ToList();
                items.Insert(0, row.Key);
                dataRow.ItemArray = items.ToArray();
                table.Rows.Add(dataRow);
            }

            return table;
        }


        public static dynamic[] ToPivotArray<T, TColumn, TRow, TData>(
            this IEnumerable<T> source,
            Func<T, TColumn> columnSelector,
            Expression<Func<T, TRow>> rowSelector,
            Func<IEnumerable<T>, TData> dataSelector)
        {

            var arr = new List<object>();
            var cols = new List<string>();
            String rowName = ((MemberExpression)rowSelector.Body).Member.Name;
            var columns = source.Select(columnSelector).Distinct();

            cols = (new[] { rowName }).Concat(columns.Select(x => x.ToString())).ToList();


            var rows = source.GroupBy(rowSelector.Compile())
                             .Select(rowGroup => new
                             {
                                 Key = rowGroup.Key,
                                 Values = columns.GroupJoin(
                                     rowGroup,
                                     c => c,
                                     r => columnSelector(r),
                                     (c, columnGroup) => dataSelector(columnGroup))
                             }).ToArray();
```foreach (var row in rows)
{
    var items = row.Values.Cast<object>().ToList();
    items.Insert(0, row.Key);
    var obj = GetAnonymousObject(cols, items);
    arr.Add(obj);
}
return arr.ToArray();
}

private static dynamic GetAnonymousObject(IEnumerable<string> columns, IEnumerable<object> values)
{
    IDictionary<string, object> eo = new ExpandoObject() as IDictionary<string, object>;
    int i;
    for (i = 0; i < columns.Count(); i++)
    {
        eo.Add(columns.ElementAt<string>(i), values.ElementAt<object>(i));
    }
    return eo;
}

public static List<dynamic> ToDynamicList(this DataTable dt)
{
    var list = new List<dynamic>();
    foreach (DataRow row in dt.Rows)
    {
        dynamic dyn = new ExpandoObject();
        list.Add(dyn);
        foreach (DataColumn column in dt.Columns)
        {
            var dic = (IDictionary<string, object>)dyn;
            dic[column.ColumnName] = row[column];
        }
    }
    return list;
}
}