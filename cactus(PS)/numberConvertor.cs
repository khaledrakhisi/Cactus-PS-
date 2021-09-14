using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persia;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace cactus_PS_
{
    class numberConvertor
    {
        private static bool isNegative(string sNumber)
        {
            if (sNumber.Contains("-"))
                return true;
            else
                return false;
        }

        public static string convertToChars(string sNumber)
        {
            string sDig, sDigType, sCharNumber;
            int nTmp;
            bool bNegative;

            bNegative = isNegative(sNumber);

            sCharNumber = "";
            //sNumber = sNumber.Replace(".", "");
            try
            {
                sNumber = ((long)long.Parse(sNumber)).ToString();

                sNumber = splitNumber(sNumber, true);

                while (sNumber != "")
                {
                    nTmp = sNumber.IndexOf(",");
                    if (nTmp > -1)
                    {
                        sDig = sNumber.Substring(0, nTmp);
                        sDigType = sNumber.Substring(sNumber.IndexOf(",") + 1, 1);
                        sNumber = sNumber.Remove(0, sNumber.IndexOf(",") + 2);

                        if (sDigType == "4")
                        {
                            sCharNumber = sCharNumber + Analyze(sDig);
                            sCharNumber = sCharNumber + " تیلیارد ";
                        }
                        else if (sDigType == "3")
                        {
                            if (int.Parse(sDig) > 0)
                            {
                                if (sCharNumber != "") sCharNumber = sCharNumber + " و ";
                                sCharNumber = sCharNumber + Analyze(sDig);
                                sCharNumber = sCharNumber + " میلیارد ";
                            }
                        }
                        else if (sDigType == "2")
                        {
                            if (int.Parse(sDig) > 0)
                            {
                                if (sCharNumber != "") sCharNumber = sCharNumber + " و ";
                                sCharNumber = sCharNumber + Analyze(sDig);
                                sCharNumber = sCharNumber + " میلیون ";
                            }
                        }
                        else if (sDigType == "1")
                        {
                            if (int.Parse(sDig) > 0)
                            {
                                if (sCharNumber != "") sCharNumber = sCharNumber + " و ";
                                sCharNumber = sCharNumber + Analyze(sDig);
                                sCharNumber = sCharNumber + " هزار ";
                            }
                        }
                    }
                    else
                    {
                        if (int.Parse(sNumber) > 0)
                        {
                            if (sCharNumber != "") sCharNumber = sCharNumber + " و ";
                            sCharNumber = sCharNumber + Analyze(sNumber);
                        }
                        else
                        {
                            if (sCharNumber == "")
                                sCharNumber = "صفر";
                        }
                        sNumber = "";

                    }

                }
            }
            catch
            {

            }
            if (bNegative )
                sCharNumber = " منفی " + sCharNumber;
            return sCharNumber;
        }
 
        private static string getFirstDigitStr(int nNumber)
        {
            string[] sNum = new string[9];

            sNum[0] = "یک";
            sNum[1] = "دو";
            sNum[2] = "سه";
            sNum[3] = "چهار";
            sNum[4] = "پنج";
            sNum[5] = "شش";
            sNum[6] = "هفت";
            sNum[7] = "هشت";
            sNum[8] = "نه";

            return sNum[nNumber-1];
        }

        private static string getSecondDigitStr(string sNumber)
        {
            string [] sNum = new string[10];
            int nIndex;
            if(int.Parse(sNumber) >= 10 && int.Parse(sNumber) <= 19)
            {
                sNum[0] = "ده";
                sNum[1] = "یازده";
                sNum[2] = "دوازده";
                sNum[3] = "سیزده";
                sNum[4] = "چهارده";
                sNum[5] = "پانزده";
                sNum[6] = "شانزده";
                sNum[7] = "هفده";
                sNum[8] = "هجده";
                sNum[9] = "نوزده";

                nIndex = int.Parse(sNumber.Substring(1, 1));
            }
            else 
            {
                sNum[2] = "بیست";
                sNum[3] = "سی";
                sNum[4] = "چهل";
                sNum[5] = "پنجاه";
                sNum[6] = "شصت";
                sNum[7] = "هفتاد";
                sNum[8] = "هشتاد";
                sNum[9] = "نود";

                nIndex = int.Parse(sNumber.Substring(0, 1));
            }
            return sNum[nIndex];
        }

        private static string getThirdDigitStr(string sNumber)
        {
            string[] sNum = new string [10];
            sNum[1] = "صد";
            sNum[2] = "دویست";
            sNum[3] = "سیصد";
            sNum[4] = "چهارصد";
            sNum[5] = "پانصد";
            sNum[6] = "ششصد";
            sNum[7] = "هفتصد";
            sNum[8] = "هشتصد";
            sNum[9] = "نهصد";

            return sNum[int.Parse(sNumber)];
        }

        private static string Analyze(string sNumber)
        {
            string sStr="", sDig="";
            while (sNumber != "")
            {
                sNumber = int.Parse(sNumber).ToString();

                if(int.Parse( sNumber) <= 0)
                {
                    if (sStr != "")
                        sNumber = "";
                    else
                    {
                        sNumber = "";
                        sStr = "صفر";
                    }
                }
                else if(int.Parse(sNumber) >= 1 && (int.Parse(sNumber) <= 9))
                {
                    if(sStr != "") sStr += " و ";
                    sStr = sStr + getFirstDigitStr(int.Parse(sNumber));
                    sNumber = sNumber.Remove(0, 1);
                }
                else if(int.Parse(sNumber) >= 10 && int.Parse(sNumber) <= 99)
                {
                    if(sStr != "")sStr += " و ";
                    sStr = sStr + getSecondDigitStr(sNumber);
                    if(int.Parse(sNumber) >= 10 && int.Parse(sNumber) <= 19)
                        sNumber = sNumber.Remove(0, 2);
                    else
                        sNumber = sNumber.Remove(0, 1);
                
                }
                else if(int.Parse(sNumber) >= 100 && int.Parse(sNumber) <= 999)
                {
                    if(sStr != "")sStr += " و ";
                    sDig = sNumber.Substring(0, 1);
                    sStr = sStr + getThirdDigitStr(sDig);
                    sNumber = sNumber.Remove(0, 1);
                }
            }
            return sStr;
        }
  
        public static string splitNumber(string sNumber, bool putSplitNumber)
        {
            int i, nDigitCount, nSeparatorCount;

            nDigitCount = 0;
            nSeparatorCount = 1;

            for (i =(byte) sNumber.Length-1; i >= 0; i--)
            {
                nDigitCount++;
                if (nDigitCount == 3)
                {
                    if (i >= 1)
                        sNumber = sNumber.Insert(i, ",");
                    if (i >= 1 && putSplitNumber)
                        sNumber = sNumber.Insert(i + 1, nSeparatorCount.ToString());
                    nSeparatorCount++;
                    nDigitCount = 0;
                }
            }
            return sNumber;
        }

        public static string convertToMonthName(string sNumber)
        {
            string[] sMonth = new string[12] {"فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند"};

            return sMonth[int.Parse(sNumber)-1];
        }

        public static string findDateError(int nAtLeastYear, string sDate)
        {
            int nFirstSlashPos = 0, nSecondSlashPos = 0;
            nFirstSlashPos = sDate.IndexOf('/', 1);
            nSecondSlashPos = sDate.IndexOf('/', nFirstSlashPos + 1);
            string sYear = sDate.Substring(0, nFirstSlashPos);
            string sMonth = sDate.Substring(nFirstSlashPos + 1, nSecondSlashPos - nFirstSlashPos - 1);
            string sDay = sDate.Substring(nSecondSlashPos + 1, sDate.Length - nSecondSlashPos - 1);

            if (int.Parse(sYear) < nAtLeastYear)
                return "y";
            if (int.Parse(sMonth) < 1 || int.Parse(sMonth) > 12)
                return "m";
            if (int.Parse(sDay) < 1 || int.Parse(sDay) > 31)
                return "d";            

            return "";
        }

        public static string makeChangeToDateString(string sDate)
        {
            int nFirstSlashPos = 0, nSecondSlashPos = 0;
            nFirstSlashPos = sDate.IndexOf('/', 1);
            nSecondSlashPos = sDate.IndexOf('/', nFirstSlashPos + 1);
            string sYear = sDate.Substring(0, nFirstSlashPos);
            string sMonth = sDate.Substring(nFirstSlashPos + 1, nSecondSlashPos - nFirstSlashPos - 1);
            string sDay = sDate.Substring(nSecondSlashPos + 1, sDate.Length - nSecondSlashPos - 1);
            if (sMonth.Length == 1)
                sMonth = '0' + sMonth;
            if (sDay.Length == 1)
                sDay = '0' + sDay;

            sYear = sYear.Replace(" ", "0");
            sMonth = sMonth.Replace(" ", "0");
            sDay = sDay.Replace(" ", "0");

            return sYear + "/" + sMonth + "/" + sDay;
        }

        public static string nowDateInAppropriateFormat()
        {
            SunDate shamsiDate = Calendar.ConvertToPersian(DateTime.Now);
            try
            {                
                string sNowDate = shamsiDate.Simple;

                sNowDate = makeChangeToDateString(sNowDate);

                return convertToEnglishDigits(sNowDate);
            }
            catch
            {                
                return convertToEnglishDigits(shamsiDate.Simple);
            }
        }

        public static string convertToEnglishDigits(string sString)
        {
            try
            {
                string sPersianDigits = "۰۱۲۳۴۵۶۷۸۹";
                string sEnglishDigits = "0123456789";
                for (int i = 0; i <= sPersianDigits.Length; i++)
                {
                    int engDigit = sString.IndexOf(sPersianDigits[i]);
                    if (engDigit != -1)
                    {
                        sString = sString.Replace(sPersianDigits[i], sEnglishDigits[i]);
                    }
                }
            }
            catch
            {
            }
            return sString;
        }

        public static int ThisComapnyID(string connectionString)
        {
            SqlCommand c = new SqlCommand();
            try
            {
                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "returnThisCompanyID";                
                SqlParameter p = c.Parameters.Add("@result", SqlDbType.Int);
                p.Direction = ParameterDirection.ReturnValue;
                c.Connection.Open();
                c.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                c.Connection.Close();
            }

            return (int)c.Parameters["@result"].Value;
        }

        public static int getSpentMasterID(string spentMasterName, string connectionString)
        {
            SqlCommand c = new SqlCommand();
            try
            {
                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "returnMasterSpentID";
                c.Parameters.AddWithValue("@spentMasterName", spentMasterName);
                SqlParameter p = c.Parameters.Add("@result", SqlDbType.Int);
                p.Direction = ParameterDirection.ReturnValue;
                c.Connection.Open();
                c.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                c.Connection.Close();
            }

            return (int)c.Parameters["@result"].Value;
        }

        public static int getDetailID(int nSpentMasterID, int _id, string sKind, string connectionString)
        {
            SqlCommand c = new SqlCommand();
            try
            {
                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "returnDetailID";
                c.Parameters.AddWithValue("@spentMasterID", nSpentMasterID);
                c.Parameters.AddWithValue("@_id", _id);
                c.Parameters.AddWithValue("@sKind", sKind);

                SqlParameter p = c.Parameters.Add("@result", SqlDbType.Int);
                p.Direction = ParameterDirection.ReturnValue;
                c.Connection.Open();
                c.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                c.Connection.Close();
            }

            return (int)c.Parameters["@result"].Value;
        }        

        public static int createDetailViaDetail(int detailID, string sKind, string connectionString)
        {
            SqlCommand c = new SqlCommand();
            try
            {
                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "createDetail";
                c.Parameters.AddWithValue("@_id", detailID);
                c.Parameters.AddWithValue("@sKind", sKind);

                SqlParameter p = c.Parameters.Add("@result", SqlDbType.Int);
                p.Direction = ParameterDirection.ReturnValue;
                c.Connection.Open();
                c.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                c.Connection.Close();
            }

            return (int)c.Parameters["@result"].Value;
        }

        public static int createDetailViaSpentMaster(int nSpentMasterID, string connectionString)
        {
            SqlCommand c = new SqlCommand();
            try
            {
                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "createDetailViaSpentMaster";
                c.Parameters.AddWithValue("@spentMasterID", nSpentMasterID);

                SqlParameter p = c.Parameters.Add("@result", SqlDbType.Int);
                p.Direction = ParameterDirection.ReturnValue;
                c.Connection.Open();
                c.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                string sMsg = "";
                if (sqlEx.Number == 547)
                {
                    sMsg = "خطای سیکول سرور:" + "\n" + "این سرفصل قبلا در سندی استفاده شده است ، شما نمی توانید سرفصل های معین این سرفصل کل را حذف کنید";
                }
                else
                {
                    sMsg = sqlEx.Message;
                }
                MessageBox.Show(sMsg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                c.Connection.Close();
            }

            return (int)c.Parameters["@result"].Value;
        }

        public static long getAccDoc_id(int _id, string sDocType, string connectionString)
        {
            SqlCommand c = new SqlCommand();
            try
            {
                c.Connection = new SqlConnection(connectionString);
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "getAccDoc_id";
                c.Parameters.AddWithValue("@_id", _id);
                c.Parameters.AddWithValue("@docType", sDocType);

                SqlParameter p = c.Parameters.Add("@result", SqlDbType.Int);
                p.Direction = ParameterDirection.ReturnValue;
                c.Connection.Open();
                c.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {                
                MessageBox.Show(sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                c.Connection.Close();
            }

            return (long)c.Parameters["@result"].Value;
        }        
    }
}
