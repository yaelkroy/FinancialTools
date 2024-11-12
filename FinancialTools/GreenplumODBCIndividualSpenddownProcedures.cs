
                        var transactions = new List<Transaction_old>[5];
                        Parallel.Invoke(
                            () => transactions[0] = GetIndividualSpenddownTransactions(awConnection, id, "transaction_1"),
                            () => transactions[1] = GetIndividualSpenddownTransactions(awConnection, id, "transaction_2"),
                            () => transactions[2] = GetIndividualSpenddownTransactions(awConnection, id, "transaction_3"),
                            () => transactions[3] = GetIndividualSpenddownTransactions(awConnection, id, "transaction_4"),
                            () => transactions[4] = GetIndividualSpenddownTransactions(awConnection, id, "transaction_5")
                        );
                        return new Tuple<string, DateTime, DateTime, Tuple<List<Transaction_old>, List<Transaction_old>, List<Transaction_old>, List<Transaction_old>, List<Transaction_old>>>(netAmountDue, rates.Item1, rates.Item2, new Tuple<List<Transaction_old>, List<Transaction_old>, List<Transaction_old>, List<Transaction_old>, List<Transaction_old>>(transactions[0], transactions[1], transactions[2], transactions[3], transactions[4]));
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
    }
}var payments = GetIndividualSpenddownPayments(awConnection, id);
var bills = GetIndividualSpenddownBills(awConnection, id);
var eligibility = GetIndividualSpenddownEligibility(awConnection, id);

await Task.WhenAll(netAmountDue, rates, expenses, payments, bills, eligibility);
var minDate = new[] { rates.Result.Item1, expenses.Result.Item1, payments.Result.Item1, bills.Result.Item1 }.Min();
var maxDate = new[] { rates.Result.Item2, expenses.Result.Item2, payments.Result.Item2, bills.Result.Item2 }.Max();

var results = new Tuple<List<Transaction_old>, List<Transaction_old>, List<Transaction_old>, List<Transaction_old>, List<Transaction_old>>(rates.Result.Item3, expenses.Result.Item3, payments.Result.Item3, bills.Result.Item3, eligibility.Result.Item3);
return new Tuple<String, DateTime, DateTime, Tuple<List<Transaction_old>, List<Transaction_old>, List<Transaction_old>, List<Transaction_old>, List<Transaction_old>>
            (netAmountDue.Result.ToString(CultureInfo.InvariantCulture), minDate, maxDate, results);
}

catch (NpgsqlException e)
{
    string errorMessages = e.ToString();
    var results = new Tuple<List<Transaction_old>, List<Transaction_old>, List<Transaction_old>, List<Transaction_old>>(null, null, null, null);
    return new Tuple<String, DateTime, DateTime, Tuple<List<Transaction_old>, List<Transaction_old>, List<Transaction_old>, List<Transaction_old>, List<Transaction_old>>
            (errorMessages, DateTime.MinValue, DateTime.MinValue, results);
}            command.ExecuteNonQuery();
            NpgsqlDataReader thisReader = (NpgsqlDataReader)command.ExecuteReader();
            while (thisReader.Read())
            {
                var transaction = new Transaction_old
                {
                    Id = thisReader.GetString(0),
                    Date = thisReader.GetDateTime(1),
                    Amount = System.Convert.ToDecimal(thisReader.GetValue(2), CultureInfo.InvariantCulture)
                };
                eligibilities.Add(transaction);
            }
            //Thread.Sleep(3000);
            //Console.WriteLine("rates stop {0}", DateTime.Now.ToLongTimeString().ToString());
            return new Tuple<DateTime, DateTime, List<Transaction_old>>(DateTime.Now, DateTime.Now, eligibilities);
        }
    }
}            command.ExecuteNonQuery();
            NpgsqlDataReader thisReader = (NpgsqlDataReader)command.ExecuteReader();
            DateTime minDate = new DateTime(3000, 1, 1), maxDate = new DateTime(1000, 1, 1);
            
            while (thisReader.Read())
            {

                DateTime date = System.Convert.ToDateTime(thisReader.GetValue(2), CultureInfo.InvariantCulture);
                Subscriber_old eligibilitySbscr = new Subscriber_old(System.Convert.ToString(thisReader.GetValue(29), CultureInfo.InvariantCulture).Trim(),
                    System.Convert.ToString(thisReader.GetValue(30), CultureInfo.InvariantCulture).Trim(),
                    System.Convert.ToString(thisReader.GetValue(85), CultureInfo.InvariantCulture).Trim(), "");
                decimal amount = 1;
                if (thisReader.GetValue(19).ToString().Contains("Y")) amount = 1;
                if (thisReader.GetValue(10).ToString().Contains("N")) amount = 0;
                var eligibility = new Transaction_old(amount,
                                                 date,
                                                 "",
                                                 System.Convert.ToString(thisReader.GetValue(0), CultureInfo.InvariantCulture),
                                                 0, eligibilitySbscr);


                if (minDate > date) minDate = date;
                if (maxDate < date) maxDate = date;

                eligibilities.Add(eligibility);

            }
            //Console.WriteLine("rates stop {0}", DateTime.Now.ToLongTimeString().ToString());
            return new Tuple<DateTime, DateTime, List<Transaction_old>>(minDate, maxDate, eligibilities);
        }
        // This is an asynchronous task to get all the BusinessEntities with one Single Rate
        public static async Task<Tuple<DateTime, DateTime, List<Transaction_old>>> GetIndividualSpenddownRates(NpgsqlConnection connection, string id)
        {//Console.WriteLine("rates start {0}", DateTime.Now.ToLongTimeString().ToString());
var rates = new List<Transaction_old>();

NpgsqlCommand command = new NpgsqlCommand(sqlQuery + id + sqlQuery, connection)
{
    CommandTimeout = 86400
};
command.ExecuteNonQuery();
NpgsqlDataReader thisReader = (NpgsqlDataReader)command.ExecuteReader();
DateTime minDate = new DateTime(3000, 1, 1), maxDate = new DateTime(1000, 1, 1);

while (thisReader.Read())
{

    DateTime date = System.Convert.ToDateTime(thisReader.GetValue(1), CultureInfo.InvariantCulture);
    Subscriber_old RateSbscr = new Subscriber_old(System.Convert.ToString(thisReader.GetValue(17), CultureInfo.InvariantCulture).Trim(),
        System.Convert.ToString(thisReader.GetValue(16), CultureInfo.InvariantCulture).Trim(),
        System.Convert.ToString(thisReader.GetValue(15), CultureInfo.InvariantCulture).Trim(), "");
    var rate = new Transaction_old(System.Convert.ToDecimal(thisReader.GetValue(8), CultureInfo.InvariantCulture),
                                     date,
                                     "",
                                     System.Convert.ToString(thisReader.GetValue(25), CultureInfo.InvariantCulture),
                                     0, RateSbscr);


    if (minDate > date) minDate = date;
    if (maxDate < date) maxDate = date;

    rates.Add(rate);

}
//Console.WriteLine("rates stop {0}", DateTime.Now.ToLongTimeString().ToString());
return new Tuple<DateTime, DateTime, List<Transaction_old>> (minDate, maxDate, rates);
}
public static async Task<Tuple<DateTime, DateTime, List<Transaction_old>>> GetIndividualSpenddownExpenses(NpgsqlConnection connection, string id)
        {
            var expenses = new List<Transaction_old>();

            NpgsqlCommand command = new NpgsqlCommand(sqlIndividualSpenddownExpenses1 + id + sqlIndividualSpenddownExpenses2 + id + sqlIndividualSpenddownExpenses3, connection)
            {
                CommandTimeout = 86400
            };
            
            command.ExecuteNonQuery();
            
            NpgsqlDataReader thisReader = (NpgsqlDataReader)command.ExecuteReader();
            
            DateTime minDate = new DateTime(3000, 1, 1), maxDate = new DateTime(1000, 1, 1);
            
            while (thisReader.Read())
            {
                Subscriber_old sbscr = new Subscriber_old(System.Convert.ToString(thisReader.GetValue(6), CultureInfo.InvariantCulture).Trim(),
                    System.Convert.ToString(thisReader.GetValue(7), CultureInfo.InvariantCulture).Trim(),
                    System.Convert.ToString(thisReader.GetValue(5), CultureInfo.InvariantCulture).Trim(), "");
                DateTime date = System.Convert.ToDateTime(thisReader.GetValue(0), CultureInfo.InvariantCulture);
                var expense = new Transaction_old(System.Convert.ToDecimal(thisReader.GetValue(3), CultureInfo.InvariantCulture),
                                                 date,
                                                 System.Convert.ToString(thisReader.GetValue(2), CultureInfo.InvariantCulture).Trim());
                expenses.Add(expense);
            }
            thisReader.Close();
            return expenses;
        }                if (minDate > date) minDate = date;
                if (maxDate < date) maxDate = date;
                
                payments.Add(payment);


            }
            //Console.WriteLine("payments stop {0}", DateTime.Now.ToLongTimeString().ToString());
            return new Tuple<DateTime, DateTime, List<Transaction_old>>(minDate, maxDate, payments);
        }e = date;
                if (maxDate < date) maxDate = date;
                
                bills.Add(bill);
            }
            //Console.WriteLine("bills stop {0}", DateTime.Now.ToLongTimeString().ToString());
            return new Tuple<DateTime, DateTime, List<Transaction_old>>(minDate, maxDate, bills);
        }
    }e = date;
                if (maxDate < date) maxDate = date;

                bills.Add(bill);

            }
            return new Tuple<DateTime, DateTime, List<Transaction_old>>(minDate, maxDate, bills);
            }
        }
        private static string GetIndividualSpenddownConnectionString(string username, string password)
        {
            return "Server=server_address;Database=database_name;port=port_number;User Id=" + username + ";Password=" + password;
        }
    }
}