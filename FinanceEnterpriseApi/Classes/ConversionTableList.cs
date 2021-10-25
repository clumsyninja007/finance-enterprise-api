using System.Collections.Generic;

namespace FinanceEnterpriseApi.Classes
{
    public static class ConversionTableList
    {
        public static List<TableListRow> TableList { get; } = new()
        {
            // Accounts Payable
            new TableListRow {TableName = "OH_DTL", KeyColumn = "OH_GL_KEY", ObjColumn = "OH_GL_OBJ", AmtColumn = "OH_REF_AMT"},
            new TableListRow {TableName = "OHB_BATCH_DTL", KeyColumn = "OH_GL_KEY", ObjColumn = "OH_GL_OBJ", AmtColumn = "OH_REF_AMT"},
            // Accounts Receivable
            new TableListRow {TableName = "AR_TRNS_DTL", KeyColumn = "AR_GL_KEY", ObjColumn = "AR_GL_OBJ", AmtColumn = "AR_PRIN_AMT"},
            new TableListRow {TableName = "AR_BATCH_DTL", KeyColumn = "ARBD_GL_KEY", ObjColumn = "ARBD_GL_OBJ", AmtColumn = "ARBD_PRIN_AMT"},
            // Encumbrance
            new TableListRow {TableName = "EN_DTL", KeyColumn = "EN_GL_KEY", ObjColumn = "EN_GL_OBJ", AmtColumn = "EN_DIST_AMT"},
            new TableListRow {TableName = "EN_BATCH_DTL", KeyColumn = "ENBD_GL_KEY", ObjColumn = "ENBD_GL_OBJ", AmtColumn = "ENBD_REF_AMT"},
            new TableListRow {TableName = "ENT_TTL_DTL", KeyColumn = "EFCC_KEY", ObjColumn = "EFCC_OBJ", AmtColumn = "ENT_EN01"},
            // General Ledger
            new TableListRow {TableName = "GLBA_BUDACT_MSTR", KeyColumn = "GLBA_KEY", ObjColumn = "GLBA_OBJ", AmtColumn = "GLB_BUDGET04"},
            new TableListRow {TableName = "GLQ_QUICK_MSTR", KeyColumn = "GLQ_KEY", ObjColumn = "GLQ_OBJ", AmtColumn = "0"},
            new TableListRow {TableName = "GLF_FULL_MSTR", KeyColumn = "GLF_KEY", ObjColumn = "GLF_OBJ", AmtColumn = "0"},
            new TableListRow {TableName = "GLT_TRNS_DTL", KeyColumn = "GLT_GL_KEY", ObjColumn = "GLT_GL_OBJ", AmtColumn = "GLT_DR"},
            new TableListRow {TableName = "GLC_BUDG_DTL", KeyColumn = "GLC_KEY", ObjColumn = "GLC_OBJ", AmtColumn = "GLC_AMT"},
            new TableListRow {TableName = "GLA_TRNS_DTL", KeyColumn = "GLT_GL_KEY", ObjColumn = "GLT_GL_OBJ", AmtColumn = "GLT_DR"},
            new TableListRow {TableName = "GLB_BATCH_DTL", KeyColumn = "GLB_KEY", ObjColumn = "GLB_OBJ", AmtColumn = "GLB_AMT"},
            // Nucleus
            // Person Entity
            // Purchasing
            new TableListRow {TableName = "POI_ITEM_DTL", KeyColumn = "POI_GL_KEY", ObjColumn = "POI_GL_OBJ", AmtColumn = "POI_AMT"},
            new TableListRow {TableName = "PON_EN_DTL", KeyColumn = "PON_GL_KEY", ObjColumn = "PON_GL_OBJ", AmtColumn = "PON_AMT"},
            // Payroll
            new TableListRow {TableName = "PYN_NUM_DTL", KeyColumn = "PYN_GLKEY", ObjColumn = "PYN_GLOBJ", AmtColumn = "0"},
            new TableListRow {TableName = "PYM_CDH_DTL", KeyColumn = "PYM_KEY01", ObjColumn = "PYM_OBJ01", AmtColumn = "0"},
            new TableListRow {TableName = "PYM_CDH_DTL", KeyColumn = "PYM_KEY02", ObjColumn = "PYM_OBJ02", AmtColumn = "0"},
            new TableListRow {TableName = "PYM_CDH_DTL", KeyColumn = "PYM_KEY03", ObjColumn = "PYM_OBJ03", AmtColumn = "0"},
            new TableListRow {TableName = "PYM_CDH_DTL", KeyColumn = "PYM_KEY04", ObjColumn = "PYM_OBJ04", AmtColumn = "0"},
            // Stores Inventory
        };
    }
}
