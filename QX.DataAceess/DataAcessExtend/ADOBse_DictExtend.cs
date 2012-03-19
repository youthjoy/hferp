using System;
using System.Collections.Generic;
using System.Text;
using QX.DataModel;

namespace QX.DataAceess
{
    public partial class ADOBse_Dict
    {
       /// <summary>
       ///  获取某列最大值
       /// </summary>
       /// <param name="field">列名</param>
       /// <param name="key">所属关键字</param>
       /// <param name="where">条件</param>
       /// <returns></returns>
        public object GetMaxByWhere(string field,string key,string where)
        {
            Bse_Dict bse_Dict = new Bse_Dict();

            string sql = string.Empty;

            if (string.IsNullOrEmpty(sql))
            {
                sql = string.Format("SELECT  Max({0}) FROM Bse_Dict WHERE 1=1 AND Dict_Key=@DictKey", field, key);
            }
            else
            {
                sql = string.Format("SELECT  Max({0}) FROM Bse_Dict WHERE 1=1 AND Dict_Key=@DictKey {2}", field, key, where);
            }

            if (string.IsNullOrEmpty(key))
            {
                idb.AddParameter("DictKey", DBNull.Value);
            }
            else
            {
                idb.AddParameter("DictKey", key);
            }
            return idb.ReturnValue(sql);
            
        }

        public object AddForReturn(Bse_Dict bse_Dict)
        {

            string sql = "INSERT INTO Bse_Dict (Dict_Key,Dict_Code,Dict_Name,Dict_PCode,Dict_PName,Dict_Desp,Dict_SCode,Dict_Bak,Dict_UDef1,Dict_UDef2,Dict_UDef3,Dict_UDef4,Dict_UDef5,Dict_Level,Dict_IsEditable,Stat,Dict_Order) VALUES (@Dict_Key,@Dict_Code,@Dict_Name,@Dict_PCode,@Dict_PName,@Dict_Desp,@Dict_SCode,@Dict_Bak,@Dict_UDef1,@Dict_UDef2,@Dict_UDef3,@Dict_UDef4,@Dict_UDef5,@Dict_Level,@Dict_IsEditable,@Stat,@Dict_Order);SELECT @@IDENTITY AS ReturnID";
            if (string.IsNullOrEmpty(bse_Dict.Dict_Key))
            {
                idb.AddParameter("@Dict_Key", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Dict_Key", bse_Dict.Dict_Key);
            }
            if (string.IsNullOrEmpty(bse_Dict.Dict_Code))
            {
                idb.AddParameter("@Dict_Code", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Dict_Code", bse_Dict.Dict_Code);
            }
            if (string.IsNullOrEmpty(bse_Dict.Dict_Name))
            {
                idb.AddParameter("@Dict_Name", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Dict_Name", bse_Dict.Dict_Name);
            }
            if (string.IsNullOrEmpty(bse_Dict.Dict_PCode))
            {
                idb.AddParameter("@Dict_PCode", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Dict_PCode", bse_Dict.Dict_PCode);
            }
            if (string.IsNullOrEmpty(bse_Dict.Dict_PName))
            {
                idb.AddParameter("@Dict_PName", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Dict_PName", bse_Dict.Dict_PName);
            }
            if (string.IsNullOrEmpty(bse_Dict.Dict_Desp))
            {
                idb.AddParameter("@Dict_Desp", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Dict_Desp", bse_Dict.Dict_Desp);
            }
            if (string.IsNullOrEmpty(bse_Dict.Dict_SCode))
            {
                idb.AddParameter("@Dict_SCode", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Dict_SCode", bse_Dict.Dict_SCode);
            }
            if (string.IsNullOrEmpty(bse_Dict.Dict_Bak))
            {
                idb.AddParameter("@Dict_Bak", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Dict_Bak", bse_Dict.Dict_Bak);
            }
            if (string.IsNullOrEmpty(bse_Dict.Dict_UDef1))
            {
                idb.AddParameter("@Dict_UDef1", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Dict_UDef1", bse_Dict.Dict_UDef1);
            }
            if (string.IsNullOrEmpty(bse_Dict.Dict_UDef2))
            {
                idb.AddParameter("@Dict_UDef2", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Dict_UDef2", bse_Dict.Dict_UDef2);
            }
            if (string.IsNullOrEmpty(bse_Dict.Dict_UDef3))
            {
                idb.AddParameter("@Dict_UDef3", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Dict_UDef3", bse_Dict.Dict_UDef3);
            }
            if (string.IsNullOrEmpty(bse_Dict.Dict_UDef4))
            {
                idb.AddParameter("@Dict_UDef4", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Dict_UDef4", bse_Dict.Dict_UDef4);
            }
            if (string.IsNullOrEmpty(bse_Dict.Dict_UDef5))
            {
                idb.AddParameter("@Dict_UDef5", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Dict_UDef5", bse_Dict.Dict_UDef5);
            }
            if (bse_Dict.Dict_Level == 0)
            {
                idb.AddParameter("@Dict_Level", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Dict_Level", bse_Dict.Dict_Level);
            }
            if (bse_Dict.Dict_IsEditable == 0)
            {
                idb.AddParameter("@Dict_IsEditable", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Dict_IsEditable", bse_Dict.Dict_IsEditable);
            }
            if (bse_Dict.Stat == 0)
            {
                idb.AddParameter("@Stat", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Stat", bse_Dict.Stat);
            }
            if (bse_Dict.Dict_Order == 0)
            {
                idb.AddParameter("@Dict_Order", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Dict_Order", bse_Dict.Dict_Order);
            }


            return idb.ReturnValue(sql);

            //return idb.ExeCmd(sql);



            //string sql = "INSERT INTO Bse_Equ (Equ_Code,Equ_Name,Equ_FixNo,Equ_CatCode,Equ_CatName,Equ_Owner,Equ_OwnerTel,Equ_Spec,Equ_Model,Equ_Manu,Equ_BuyDate,Equ_Stat,Equ_Bak,Equ_MaintainPep,Equ_MaintainTel) VALUES (@Equ_Code,@Equ_Name,@Equ_FixNo,@Equ_CatCode,@Equ_CatName,@Equ_Owner,@Equ_OwnerTel,@Equ_Spec,@Equ_Model,@Equ_Manu,@Equ_BuyDate,@Equ_Stat,@Equ_Bak,@Equ_MaintainPep,@Equ_MaintainTel);SELECT @@IDENTITY AS ReturnID;";
            //if (string.IsNullOrEmpty(bse_Equ.Equ_Code))
            //{
            //    idb.AddParameter("@Equ_Code", DBNull.Value);
            //}
            //else
            //{
            //    idb.AddParameter("@Equ_Code", bse_Equ.Equ_Code);
            //}
            //if (string.IsNullOrEmpty(bse_Equ.Equ_Name))
            //{
            //    idb.AddParameter("@Equ_Name", DBNull.Value);
            //}
            //else
            //{
            //    idb.AddParameter("@Equ_Name", bse_Equ.Equ_Name);
            //}
            //if (string.IsNullOrEmpty(bse_Equ.Equ_FixNo))
            //{
            //    idb.AddParameter("@Equ_FixNo", DBNull.Value);
            //}
            //else
            //{
            //    idb.AddParameter("@Equ_FixNo", bse_Equ.Equ_FixNo);
            //}
            //if (string.IsNullOrEmpty(bse_Equ.Equ_CatCode))
            //{
            //    idb.AddParameter("@Equ_CatCode", DBNull.Value);
            //}
            //else
            //{
            //    idb.AddParameter("@Equ_CatCode", bse_Equ.Equ_CatCode);
            //}
            //if (string.IsNullOrEmpty(bse_Equ.Equ_CatName))
            //{
            //    idb.AddParameter("@Equ_CatName", DBNull.Value);
            //}
            //else
            //{
            //    idb.AddParameter("@Equ_CatName", bse_Equ.Equ_CatName);
            //}
            //if (string.IsNullOrEmpty(bse_Equ.Equ_Owner))
            //{
            //    idb.AddParameter("@Equ_Owner", DBNull.Value);
            //}
            //else
            //{
            //    idb.AddParameter("@Equ_Owner", bse_Equ.Equ_Owner);
            //}
            //if (string.IsNullOrEmpty(bse_Equ.Equ_OwnerTel))
            //{
            //    idb.AddParameter("@Equ_OwnerTel", DBNull.Value);
            //}
            //else
            //{
            //    idb.AddParameter("@Equ_OwnerTel", bse_Equ.Equ_OwnerTel);
            //}
            //if (string.IsNullOrEmpty(bse_Equ.Equ_Spec))
            //{
            //    idb.AddParameter("@Equ_Spec", DBNull.Value);
            //}
            //else
            //{
            //    idb.AddParameter("@Equ_Spec", bse_Equ.Equ_Spec);
            //}
            //if (string.IsNullOrEmpty(bse_Equ.Equ_Model))
            //{
            //    idb.AddParameter("@Equ_Model", DBNull.Value);
            //}
            //else
            //{
            //    idb.AddParameter("@Equ_Model", bse_Equ.Equ_Model);
            //}
            //if (string.IsNullOrEmpty(bse_Equ.Equ_Manu))
            //{
            //    idb.AddParameter("@Equ_Manu", DBNull.Value);
            //}
            //else
            //{
            //    idb.AddParameter("@Equ_Manu", bse_Equ.Equ_Manu);
            //}
            //if (bse_Equ.Equ_BuyDate == DateTime.MinValue)
            //{
            //    idb.AddParameter("@Equ_BuyDate", DBNull.Value);
            //}
            //else
            //{
            //    idb.AddParameter("@Equ_BuyDate", bse_Equ.Equ_BuyDate);
            //}
            //if (bse_Equ.Equ_Stat == 0)
            //{
            //    idb.AddParameter("@Equ_Stat", DBNull.Value);
            //}
            //else
            //{
            //    idb.AddParameter("@Equ_Stat", bse_Equ.Equ_Stat);
            //}
            //if (string.IsNullOrEmpty(bse_Equ.Equ_Bak))
            //{
            //    idb.AddParameter("@Equ_Bak", DBNull.Value);
            //}
            //else
            //{
            //    idb.AddParameter("@Equ_Bak", bse_Equ.Equ_Bak);
            //}
            //if (string.IsNullOrEmpty(bse_Equ.Equ_MaintainPep))
            //{
            //    idb.AddParameter("@Equ_MaintainPep", DBNull.Value);
            //}
            //else
            //{
            //    idb.AddParameter("@Equ_MaintainPep", bse_Equ.Equ_MaintainPep);
            //}
            //if (string.IsNullOrEmpty(bse_Equ.Equ_MaintainTel))
            //{
            //    idb.AddParameter("@Equ_MaintainTel", DBNull.Value);
            //}
            //else
            //{
            //    idb.AddParameter("@Equ_MaintainTel", bse_Equ.Equ_MaintainTel);
            //}
            //return idb.ReturnValue(sql);
            //return idb.ExeCmd(sql);
        }
    }
}
