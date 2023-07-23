using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVS.Core.Models.SheardCode
{
    public class CommonProp
    {
        #region AllProp
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDeleted2 { get; set; }
        public bool IsDeleted3 { get; set; }
        public DateTime CreationData { get; set; }
        #endregion

        #region Enums
         public enum Genders
        {
            نێر ,مێ,نێرەموک

        }
        public enum BirthTyps
        {
            نەشتەرگەری, لەدایکبوونی_ئاسایی
        }
        public enum NumberOfBirths
        {
            تاک ,دووانە ,سیانە ,زیاتر
        }
        public enum PlaceOfBirths
        {
            ماڵ, نەخۆشخانە , بنکە 
        }
        public enum BirthOccurredBys
        {
            پزیشک ,پەرستار ,مامان ,هیتر
        }
        public enum DocumentTypes
        {
           ناسنامەی_باری_شارستانی, پاسپۆرت ,کارتی_نیشتیمانی
        }
        public enum NationalIdFors
        {
           دایک,باوک 
        }
        #endregion
    }
}
