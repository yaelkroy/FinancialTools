= eligibility.meme_ck
            LEFT JOIN ODS_FACETS.cmc_meme_member member
            ON member_ck.meme_hist_link_id = member.meme_ck
            LEFT JOIN ODS_FACETS.cmc_blei_benefit_elig_info blei
            ON blei.blei_meme_ck = member_ck.meme_ck
            WHERE member_ck.meme_last_name = :last_name
            AND member_ck.meme_first_name = :first_name
            AND member_ck.meme_birth_dt = :birth_dt
            AND member_ck.meme_ssn = :ssn
            AND member_ck.meme_record_no = :record_no
            AND eligibility.mepe_eff_dt <= :eff_dt
            AND eligibility.mepe_term_dt > :eff_dt
            AND eligibility.cspi_id = 'HICN'
            AND eligibility.pdpd_id = 'PDP'
            AND blei.blei_ck IS NOT NULL";
    }
}st string sqlCheckDBIExpenses2 = @") AND expenses.bldi_fee_disc_amt <> 0 ORDER BY bills.sbsb_ck, expenses.bldi_update_dtm DESC;";string sqlCheckDBIExpenses2 = @" ) ORDER BY sbsb_ck, bldi_update_dtm;";