using CRVS.Core.Models.SheardCode;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CRVS.Core.Models
{
    public class BrithCertificate : CommonProp
    {
        public Guid BrithCertificateId { get; set; }
        public string? CertificateNo { get; set; }
        public string? HealthID { get; set; }
        [Required]
        [Display(Name = "ناوی منداڵ")]
        public string? ChildName { get; set; }
        public Genders Gender { get; set; }
        [Required]
        [Display(Name = "پارێزگا")]
        public string? Governorate { get; set; }
        [Required]
        [Display(Name = "بەرێوەبەرایەتی")]

        public string? DOH { get; set; }
        [Required]
        [Display(Name = "کەرت")]
        public string? District { get; set; }
        [Required]
        [Display(Name = "ناحیە")]
        public string? Nahia { get; set; }
        [Display(Name = "گوند")]
        public string? Village { get; set;}
        [Display(Name = "جۆری لە دایک بوون")]
        public string? BrithType { get; set; }
        [Required]
        [Display(Name = "ژمارەی لە دایک بوون")]
        public decimal NumberOfBirth { get; set; } = 0;
        [Required]
        [Display(Name = "کاتژمێر")]
        public TimeSpan BHour { get; set; }
        public DateTime BOD { get; set; }
        [Required]
        [Display(Name = "رێکەوتی لە دایک بوون بە نووسین")]
        public string? BODtext { get; set;}
        [Required]
        [Display(Name = "ناوی یەکەمی باووک")]
        public string? FatherFName { get; set; }
        [Required]
        [Display(Name = "ناوی دووەمی باووک")]
        public string? FatherMName { get; set; }
        [Required]
        [Display(Name = "ناوی سێ یەمی باووک")]
        public string? FatherLName { get; set; }
        public string? FatherFullName { get; set; }
        [Required]
        [Display(Name = "ساڵی لەدایک بوونی باووک")]
        public int FatherBOD { get; set; }
        [Required]
        [Display(Name = "تەمەنی باووک")]
        public int FatherAge { get;set; }
        [Required]
        [ForeignKey("Job")]
        [Display(Name = "پیشەی باووک")]
        public int FatherJob { get; set; }
        [Required]
        [ForeignKey("Nationality")]
        [Display(Name = "ڕەگەزنامەی باووک")]
        public string? FatherNationality { get;set; }
        [Required]
        [ForeignKey("Religion")]
        [Display(Name = " ئاینی باووک")]
        public string? FatherReligion { get;set; }
        [Required]
        [Display(Name = "ژمارەی مۆبایلی باووک")]
        public int FatherMobile { get;set; }
        [Required]
        [Display(Name = "ناوی یەکەمی دایک")]

        public string? MotherFName { get; set; }
        [Required]
        [Display(Name = "ناوی دووەمی دایک")]
        public string? MotherMName { get; set; }
        [Required]
        [Display(Name = "ناوی سێ یەمی دایک")]
        public string? MotherLName { get; set; }
        public string? MotherFullName { get; set; }
        [Required]
        [Display(Name = "ساڵی لەدایک بوونی دایک")]
        public int MotherBOD { get; set; }
        [Required]
        [Display(Name = "تەمەنی دایک")]
        public int MotherAge { get; set; }
        [Required]
        [ForeignKey("Job")]
        [Display(Name = "پیشەی دایک")]
        public int MotherJob { get; set; }
        [Required]
        [ForeignKey("Nationality")]
        [Display(Name = "ڕەگەزنامەی دایک")]
        public string? MotherNationality { get; set; }
        [Required]
        [ForeignKey("Religion")]
        [Display(Name = "ئاینی دایک")]
        public string? MotherReligion { get; set; }
        [Required]
        [Display(Name = "ژمارەی مۆبایلی دایک")]
        public int MotherMobile { get; set; }
        [Required]
        [Display(Name = "پەیوەندی خزمایەتی نێوان باووک و دایک")]
        public bool Relative { get; set; }
        [Required]
        [Display(Name = "زیندوو")]
        public int Alive { get; set; }
        [Required]
        [Display(Name = "بەزیندووی لەدایک بووە دواتر مردووە")]
        public int BornAliveThenDied { get;set; }
        [Required]
        [Display(Name = "لەدایک بووە بەمردووی")]
        public int StillBirth { get;set; }
        [Required]
        [Display(Name = "لەدایک بووە بەکەم ئەندامی")]
        public int BornDisable { get;set; }
        [Required]
        [Display(Name = "ژمارەی لەبارچوون")]
        public int NoAbortion { get;set;}
        [Required]
        [Display(Name = "")]
        public bool IsDisabled { get;set; }
        [Required]
        [Display(Name = "")]
        public string? IsDisabledType { get;set; }
        [Required]
        [Display(Name = "")]
        public string? DisabledType { get; set; }
        [Required]
        [Display(Name = "ماوەی دووگیانی")]
        public int DurationOfPregnancy { get;set; }
        [Required]
        [Display(Name = "کێشی منداڵ")]
        public decimal BabyWeight { get;set; }
        [Required]
        [Display(Name = "شوێنی لەدایک بوون")]
        public PlaceOfBirths PlaceOfBirth { get; set; }
        [Required]
        [Display(Name = "لەدایک بوون رویدا بەهۆی ")]
        public BirthOccurredBys BirthOccurredBy { get; set; }
        [Required]
        [Display(Name = "ژمارەی مۆڵەت")]
        public int LicenseNo { get; set;}
        [Required]
        [Display(Name = "ساڵی مۆڵەت")]
        public int LicenseYear { get;set ; }
        [Required]
        [Display(Name = "پارێزگا")]
        public string? FamilyGovernorate { get; set;}
        [Required]
        [Display(Name = "کەرت")]
        public string? FamilyDistrict { get; set;}
        [Required]
        [Display(Name = "ناحیە")]
        public string? FamilyNahiah { get; set; }
        [Required]
        [Display(Name = "گەرەک")]
        public string? FamilyMahala { get; set; }
        [Required]
        [Display(Name = "بەرێوەبەرایەتی")]
        public string? FamilyDOH { get; set; }
        [Required]
        [Display(Name = "کەرت")]
        public string? FamilySector { get; set; }
        [Required]
        [Display(Name = "بنکەی تەندروستی")]
        public string? FamilyPHC { get; set; }
        [Required]
        [Display(Name = "کۆڵان")]
        public string? FamilyZigag { get; set; }
        [Required]
        [Display(Name = "خانوو")]
        public string? FamilyHomeNo { get; set; }
        [Required]
        [Display(Name = "بەڵگەنامەکان")]
        public DocumentTypes DocumentType { get; set; }
        [Required]
        [Display(Name = "ژمارەی تۆمار")]
        public string? RecordNumber { get; set; }
        [Required]
        [Display(Name = "لاپەڕە")]

        public string? PageNumbertor { get; set; }
        [Required]
        [Display(Name = "بەرێوەبەرایەتی باری شارستانی")]
        public string? CivilStatusDirectorate { get; set;}
        [Required]
        [Display(Name = "پارێزگا")]
        public string? GovernorateCivilStatusDirectorate { get; set; }
        [Required]
        [Display(Name = "کارتی نیشتیمانی")]
        public NationalIdFors NationalIdFor { get; set; }
        [Required]
        [Display(Name = "ژمارەی کارتی نیشتیمانی")]
        public int NationalID { get; set; }
        [Required]
        [Display(Name = "پاسەپۆرت")]
        public string? PassportNo { get; set; }
        [Required]
        [Display(Name = "ناوی راگەیەنەر")]
        public string? InformerName { get; set; }
        [Required]
        [Display(Name = "ناونیشانی")]
        public string? InformerJobTitle { get; set; }
        [Required]
        [Display(Name = "پەیوەندی بە لەدایک بوو")]
        public string? KinshipOfTheNewborn { get; set; }
        [Required]
        [Display(Name = "ناوی ئەنجامدەر")]
        public string? BirthPerformerName { get; set; }
        [Required]
        [Display(Name = "ناونیشانی کارکردن")]
        public string? BirthPerformerWorkingAddress { get; set; }
        [Required]
        [Display(Name = "ناوی بەرێوەبەری نەخۆشخانە")]
        public string? HospitalManagerName { get; set; }
        [Required]
        [Display(Name = "واژووی بەرێوەبەری نەخۆشخانە")]
        public string? HospitalManagerSig { get; set; }
        [Required]
        [Display(Name = "")]
        public int RationCard { get; set; }
        [Required]
        [Display(Name = "وێنەی بەڵگەنامەی لەدایک بوون")]
        public string? ImgBirthCertificate { get; set; }
        [Required]
        [Display(Name = "گرێبەستی هاوسەرگیری")]
        public string? ImgMarriageCertificate { get; set; }
        [Required]
        [Display(Name = "کارتی نیشتمانی باووک رووی پێشەوە")]
        public string? ImgFatherUnifiedNationalIdFront { get; set; }
        [Required]
        [Display(Name = "کارتی نیشتمانی  باووک رووی دواوە")]
        public string? ImgFatherUnifiedNationalIdBack { get; set; }
        [Required]
        [Display(Name = "کارتی نیشتمانی دایک رووی پێشەوە")]
        public string? ImgMotherUnifiedNationalIdFront { get; set; }
        [Required]
        [Display(Name = "کارتی نیشتمانی دایک رووی دواوە")]
        public string? ImgMotherUnifiedNationalIdBack { get; set; }
        [Required]
        [Display(Name = "کارتی زانیاری رووی پێشەوە")]
        public string? ImgResidencyCardFront { get; set; }
        [Required]
        [Display(Name = "کارتی زانیاری رووی دواوە")]
        public string? ImgResidencyCardBack { get; set; }
        
        public string? AllPDFs { get; set; }
      
        public string? QrCode { get; set; }
      
        public bool FirstStage { get; set; }
      
        public bool SecondStage { get; set; }
       
        public bool Approval { get; set; }
        public bool Creator { get; set; }
     
 
    }
}
