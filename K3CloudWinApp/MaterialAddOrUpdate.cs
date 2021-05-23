using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K3CloudWinApp
{
    public partial class MaterialAddOrUpdate : Form
    {
        public MaterialAddOrUpdate()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string jsonStr = "{" + 
                "'NeedUpDateFields': []," + 
                "'NeedReturnFields': ['FMATERIALID','FNUMBER']," +
                "'IsDeleteEntry': 'true'," +
                "'SubSystemId': ''," +
                "'IsVerifyBaseDataField': 'false'," +
                "'IsEntryBatchFill': 'true'," + 
                " 'ValidateFlag': 'true'," +
                "'NumberSearch': 'true'," +
                "'InterationFlags': ''," + 
                "'Model': {" +
                "'FMATERIALID': 0,"  +
                "'FCreateOrgId': {" +  //创建组织
                "'FNumber': '101.2'" + 
                "}," +
                "'FUseOrgId': {" + //使用组织
                "'FNumber': '101.2'" +
                "}," + 
                "'FNumber': ''," +  //更新时可以
                "'FName': '测试',"  + // 名称
                "'SubHeadEntity': {" +
                "'FErpClsID': '1'," +//物料属性
                "'FFeatureItem': '',"+ //特征件子项
                "'FCategoryID': {" + //存货类别
                    "'FNumber': ''" +
                "}," +
                "'FBaseUnitId': {" + // 基本单位
                    "'FNumber': 'Pcs'" +
                "}," +
                "'FSuite': ''" + //套件
                "}," +
                "'SubHeadEntity1': {" +
                    "'FStoreUnitID': {" + //库存单位
                        "'FNumber': ''" + 
                    "}," +
                    "'FUnitConvertDir': ''," + //换算方向
                    "'FCurrencyId': {" + //币别
                        "'FNumber': ''" +
                    "}," + 
                    "'FSNManageType': ''," +//业务范围
                    "'FSNGenerateTime': ''" + //序列号生成时机
                "}," +
                "'SubHeadEntity2': {" +
                    "'FSaleUnitId': {" + //销售单位
                        "'FNumber': ''" +
                    "}," +
                    "'FSalePriceUnitId': {" + // 销售计价单位
                        "'FNumber': ''" +
                    "}" + 
                "}," +
                "'SubHeadEntity3': {" +
                    "'FPurchaseUnitId': {" +  //采购单位
                        "'FNumber': ''" +
                    "}," + 
                    "'FPurchasePriceUnitId': {" +  //采购计价单位
                        "'FNumber': ''" +
                    "}," +
                    "'FQuotaType': ''," +  //配额方式
                "}," +
                "'SubHeadEntity4': {" +
                    "'FPlanningStrategy': ''," +   // 计划策略
                    "'FOrderPolicy': ''," +  //订货策略
                    "'FFixLeadTimeType': ''," + // 固定提前期单位
                    "'FVarLeadTimeType': ''," +  //变动提前期单位
                    "'FCheckLeadTimeType': ''," + //检验提前期单位
                    " 'FOrderIntervalTimeType': ''," +  //订货间隔期单位
                    "'FReserveType': ''," +  //预留类型
                    "'FPlanOffsetTimeType': ''," +   //时间单位
                "'SubHeadEntity5': {" +
                    "'FIssueType': ''," +   //发料方式
                    "'FOverControlMode': ''," +// 超发控制方式
                    "'FMinIssueUnitId': {" +   //最小发料批量单位
                       " 'FNUMBER': ''" +
                    "}," +
                    "'FStandHourUnitId': ''," +    //工时单位
                    "'FBackFlushType': ''" +   //倒冲数量
                "}," +
                "'FEntityInvPty': [" + 
                    "{" +
                        "'FInvPtyId': {"  +//库存属性
                            "'FNumber': ''" +
                        "} } ] } }";
                    
        }
    }
}
