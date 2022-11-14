using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingLibrary.models.enums
{
   public enum OrderStatus
    {
        under_consideration,
        agree,
        done,
        canceled

    }

   public enum ConnectorType
    {

        trs_m,
        ts_m,
        xlr_m,
        rca_m,
        trs_f,
        ts_f,
        xlr_f,
        rca_f,
        bnc


    }

}
