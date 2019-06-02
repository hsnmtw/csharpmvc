using MVCHIS.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCHIS.Tools {
    //[ForModel(MODELS.Dictionary, Enabled = true)]
    public class DictionaryController : AbstractDBController<DictionaryModel> {

        
        private static Dictionary<string, string> en = new Dictionary<string, string>();
        private static Dictionary<string, string> ar = new Dictionary<string, string>();

        public static LanguageState LanguageState { get; set; }

        public string this[string word]{
            get {
                if(LanguageState == LanguageState.Arabic)
                    return en.ContainsKey(word) ? en[word] : word;
                else
                    return ar.ContainsKey(word) ? ar[word] : word;
            }
            set {
                en[word] = value;
            }
        }

        public DictionaryController() : base() {
            ReadDictionary();
        }


        public void ReadDictionary() { 
            try {
                foreach (var row in Read()) {
                    var WordInArabic = row.WordInArabic;
                    var WordInEnglish = row.WordInEnglish;
                    en[WordInEnglish] = WordInArabic;
                    ar[WordInArabic] = WordInEnglish;
                }
            } catch(Exception ex) {
                Console.WriteLine($"EXCEPTION: {ex.Message}");
            }
        }


        public void Initialize() {
            string[][] data = {
                new string[]{"File","ملف"},
                new string[]{"Operations","العمليات"},
                new string[]{"Record Id","رقم السجل"},
                new string[]{"Word In English","الكلمة بلانجليزي"},
                new string[]{"Word In Arabic","الكلمة بالعربي"},
                new string[]{"Created by","اضيفت بواسطة"},
                new string[]{"Updated by","التحديث بواسطة"},
                new string[]{"Read Only","مقروء فقط"},
                new string[]{"Save","حفظ"},
                new string[]{"New","جديد"},
                new string[]{"Remove","حذف"},
                new string[]{"User Name","اسم المستخدم"},
                new string[]{"Full Name","الاسم الكامل"},
                new string[]{"Email","البريد الاليكتروني"},
                new string[]{"Password","كلمة المرور"},
                new string[]{"Confirm Password","تأكيد كلمة المرور"},
                new string[]{"Is Active","حالة التفعيل"},
                new string[]{"Failed Login Attempts","مرات الدخول الفاشلة"},
                new string[]{"Last Password Reset","آخر تغيير لكلمة المرور"},
                new string[]{"Entitlement Group Name","اسم مجموعة الصلاحيات"},
                new string[]{"Entitlement Name","اسم الصلاحية"},
                new string[]{"Description","الشرح"},
                new string[]{"Entitlement Group","مجموعة الصلاحيات"},
                new string[]{"Entitlements","الصلاحيات"},
                new string[]{"Legend:","المعاني:"},
                new string[]{"C: Create","C: انشاء"},
                new string[]{"R: Read","R: قراءة"},
                new string[]{"U: Update","U: تحديث"},
                new string[]{"D: Delete","D: حذف"},
                new string[]{"Rooms","الغرف"},
                new string[]{"Room Name","اسم الغرفة"},
                new string[]{"Windows","عدد النوافذ"},
                new string[]{"Bed Capacity","عدد المراتب"},
                new string[]{"Country","الدولة"},
                new string[]{"Building Name","اسم المبنى"},
                new string[]{"Reports","التقارير"},
                new string[]{"Security","الصلاحيات و الأذونات"},
                new string[]{"Customers","العملاء"},
                new string[]{"Housing","الاسكان"},
                new string[]{"Billing","الفواتير"},
                new string[]{"Developer","المطورون"},
                new string[]{"Window","نافذة"},
                new string[]{"Tools","الأدوات"},
                new string[]{"Arabic","لغة عربية"},
                new string[]{"Log in","تسجيل الدخول"},
                new string[]{"Log out","تسجيل الخروج"},
                new string[]{"Password Reset","اعادة تعيين كلمة المرور"},
                new string[]{"Configurations","اعدادات الضبط"},
                new string[]{"E&xit","خروج"},
                new string[]{"Close","إغلاق"},
                new string[]{"Duplicate","تكرار"},
                new string[]{"Room Movement","تغيير غرفة"},
                new string[]{"Buildings","المباني"},
                new string[]{"Compounds","مجمعات الاسكان"},
                new string[]{"Compound","مجمع اسكان"},
                new string[]{"Building Types","انواع المباني"},
                new string[]{"Projects","المشاريع"},
                new string[]{"Identification Types","أنواع الهوية"},
                new string[]{"Identification","الهوية"},
                new string[]{"Clients","الزبائن"},
                new string[]{"Client Types","أنواع الزبائن"},
                new string[]{"Dictionary","المعجم"},
                new string[]{"عربي","English"},
                new string[]{"Date Conversion","تغيير التواريخ"},
                new string[]{"Arrange Icons","ترتيب الرموز"},
                new string[]{"Tile &Horizontal","ترتيب افقي"},
                new string[]{"Tile &Vertical","ترتيب عمودي"},
                new string[]{"&Cascade","ترتيب محوري"},
                new string[]{"Close &All","أغلاق كل النوافذ"},
                new string[]{"Reset","اعادة تعيين"},
                new string[]{"Last Login Date/Time","أخر تسجيل دخول"},
                new string[]{"Profile","الملف الشخصي"},
                new string[]{"Profiles","الملفات الشخصية"},
                new string[]{"Profile Name","اسم الملف الشخصي"},
                new string[]{"&Open","فتح"},
                new string[]{"&Allow All","السماح للكل"},
                new string[]{"&Unallow All","عدم السماح للكل"},
                new string[]{"Audit","سجل العمليات المرجعي"},
                new string[]{"Housing Information System","نظام المعلومات الاسكانية"},
                new string[]{"by Hussain Almutawa","برمجة / حسين المطوع"},
                new string[]{"Copyrights (c) 2004 - 2019","حقوق النسخ محفوظة 2004 - 2019"},
                new string[]{"Contracts","العقود"},
                new string[]{"Bills","الفوترة"},
                new string[]{"Billing Categories","فئات الفواتير"},
                new string[]{"Accommodation Classes","مجموعات الاسكان"},
                new string[]{"Food Classes","مجموعات الطعام"},
                new string[]{"Food Types","انواع الطعام"},
                new string[]{"Users","المستخدمون"},
                new string[]{"Entitlement Groups","مجاميع الصلاحيات"},
                new string[]{"Residents Search","البحث عن النزلاء"},
                new string[]{"Residents","النزلاء"},
                new string[]{"Help","مساعدة"},
                new string[]{"About","حول"},
                new string[]{"Encryption Tool","اداة التشفير"},
                new string[]{"Controllers Registry","ادارة الخدمات"},
                new string[]{"Compact and Repair","اصلاح و ضغط قاعدة البيانات"},
                new string[]{"Table Designer","تصميم جداول قاعدة البيانات"},
                new string[]{"SQL Viewer","صيانة قاعدة البيانات"},
                new string[]{"Month","الشهر"},
                new string[]{"Year","السنة"},
                new string[]{"Calendar","التقويم"},
                new string[]{"Sat","سب"},
                new string[]{"Sun","أح"},
                new string[]{"Mon","اث"},
                new string[]{"Tue","ثلا"},
                new string[]{"Wed","ارب"},
                new string[]{"Thu","خمس"},
                new string[]{"Fri","جمع"},
                new string[]{"Profile Entitlements","صلاحيات الملف الشخصي"},
            };
            foreach(string[]words in data) {
                Save(new DictionaryModel() { WordInEnglish=words[0],WordInArabic=words[1] });
            }
        }

    }
}
