using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace IdiomsService.Migrations
{
    public partial class languages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Languages_LanguageFamilies_LanguageFamilyId",
                table: "Languages");

            migrationBuilder.DropTable(
                name: "LanguageFamilies");

            migrationBuilder.DropIndex(
                name: "IX_Languages_LanguageFamilyId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "LanguageFamilyId",
                table: "Languages");

            migrationBuilder.AddColumn<string>(
                name: "NativeName",
                table: "Languages",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegionCode",
                table: "Languages",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[,]
                {
                    { 1, "en", "English", "English", "US" },
                    { 94, "ne", "Nepali", "नेपाली", "NP" },
                    { 95, "se", "Sami Northern", "davvisámegiella", "NO" },
                    { 96, "qu", "Quechua", "Runasimi", "BO" },
                    { 97, "os", "Afar", "Qafar", "ET" },
                    { 98, "ps", "Pashto", "پښتو", "AF" },
                    { 99, "rm", "Romansh", "rumantsch", "CH" },
                    { 93, "mt", "Maltese", "Malti", "MT" },
                    { 100, "si", "Sinhala", "සිංහල", "LK" },
                    { 102, "tk", "Turkmen", "Türkmen dili", "TM" },
                    { 103, "hsb", "Upper Sorbian", "hornjoserbšćina", "DE" },
                    { 104, "yo", "Yoruba", "Èdè Yorùbá", "NG" },
                    { 105, "kw", "Afar", "Qafar", "ET" },
                    { 106, "haw", "Hawaiian", "ʻŌlelo Hawaiʻi", "US" },
                    { 107, "ln", "Afar", "Qafar", "ET" },
                    { 101, "to", "Afar", "Qafar", "ET" },
                    { 108, "wo", "Wolof", "Wolof", "SN" },
                    { 92, "mi", "Maori", "te reo Māori", "NZ" },
                    { 90, "fur", "Afar", "Qafar", "ET" },
                    { 76, "ba", "Bashkir", "Башҡорт", "RU" },
                    { 77, "ksh", "Afar", "Qafar", "ET" },
                    { 78, "fy", "Western Frisian", "Frysk", "NL" },
                    { 79, "yi", "Afar", "Qafar", "ET" },
                    { 80, "mg", "Malagasy", "Malagasy", "ET" },
                    { 81, "gd", "Scottish Gaelic", "Gàidhlig", "GB" },
                    { 91, "gv", "Afar", "Qafar", "ET" },
                    { 82, "ce", "Afar", "Qafar", "ET" },
                    { 84, "sd", "Sindhi", "سنڌي", "PK" },
                    { 85, "km", "Khmer", "ភាសាខ្មែរ", "KH" },
                    { 86, "am", "Amharic", "አማርኛ", "ET" },
                    { 87, "co", "Corsican", "Corsu", "FR" },
                    { 88, "dv", "Divehi", "ދިވެހިބަސް", "MV" },
                    { 89, "fo", "Faroese", "føroyskt", "FO" },
                    { 83, "pa", "Punjabi", "ਪੰਜਾਬੀ", "IN" },
                    { 109, "ky", "Kyrgyz", "Кыргыз", "KG" },
                    { 110, "ig", "Igbo", "Igbo", "NG" },
                    { 111, "or", "Odia", "ଓଡ଼ିଆ", "IN" },
                    { 131, "rw", "Kinyarwanda", "Kinyarwanda", "RW" },
                    { 132, "xh", "isiXhosa", "isiXhosa", "ZA" },
                    { 133, "kl", "Greenlandic", "kalaallisut", "GL" },
                    { 134, "dz", "Afar", "Qafar", "ET" },
                    { 135, "ts", "Xitsonga", "Xitsonga", "ZA" },
                    { 136, "st", "Sesotho", "Sesotho", "ZA" },
                    { 130, "ss", "Afar", "Qafar", "ET" },
                    { 137, "ak", "Afar", "Qafar", "ET" },
                    { 139, "ff", "Fulah", "Fulah", "SN" },
                    { 140, "lg", "Afar", "Qafar", "ET" },
                    { 141, "rny", "Afar", "Qafar", "ET" },
                    { 142, "ve", "Afar", "Qafar", "ET" },
                    { 143, "tn", "Setswana", "Setswana", "ZA" },
                    { 144, "ki", "Afar", "Qafar", "ET" },
                    { 138, "ks", "Afar", "Qafar", "ET" },
                    { 129, "zu", "isiZulu", "isiZulu", "ZA" },
                    { 128, "bm", "Afar", "Qafar", "ET" },
                    { 127, "ti", "Tigrinya", "ትግርኛ", "ER" },
                    { 112, "gn", "Guarani", "Avañe’ẽ", "PY" },
                    { 113, "so", "Somali", "Soomaali", "SO" },
                    { 114, "kab", "Afar", "Qafar", "ET" },
                    { 115, "ug", "Uyghur", "ئۇيغۇرچە", "CN" },
                    { 116, "ha", "Hausa", "Hausa", "NG" },
                    { 117, "mzn", "Afar", "Qafar", "ET" },
                    { 118, "pap", "Afar", "Qafar", "ET" },
                    { 119, "cu", "Afar", "Qafar", "ET" },
                    { 120, "sah", "Sakha", "Саха", "RU" },
                    { 121, "sn", "Shona", "chiShona", "ET" },
                    { 122, "lo", "Lao", "ລາວ", "LA" },
                    { 123, "iu", "Inuktitut", "Inuktitut", "CA" },
                    { 124, "bo", "Tibetan", "བོད་ཡིག", "CN" },
                    { 125, "om", "Oromo", "Oromoo", "ET" },
                    { 126, "ee", "Afar", "Qafar", "ET" },
                    { 75, "oc", "Occitan", "Occitan", "FR" },
                    { 74, "nds", "Afar", "Qafar", "ET" },
                    { 73, "tg", "Tajik", "тоҷикӣ", "TJ" },
                    { 72, "gu", "Gujarati", "ગુજરાતી", "IN" },
                    { 21, "no", "Norwegian Bokmål", "norsk bokmål", "NO" },
                    { 22, "fi", "Finnish", "suomi", "FI" },
                    { 23, "hu", "Hungarian", "magyar", "HU" },
                    { 24, "tr", "Turkish", "Türkçe", "TR" },
                    { 25, "ro", "Romanian", "română", "RO" },
                    { 26, "da", "Danish", "dansk", "DK" },
                    { 20, "ca", "Catalan", "català", "ES" },
                    { 27, "el", "Greek", "Ελληνικά", "GR" },
                    { 29, "hi", "Hindi", "हिन्दी", "IN" },
                    { 30, "bn", "Bangla", "বাংলা", "BD" },
                    { 31, "az", "Azerbaijani", "azərbaycan", "AZ" },
                    { 32, "sw", "Kiswahili", "Kiswahili", "KE" },
                    { 33, "kk", "Kazakh", "қазақ тілі", "KZ" },
                    { 34, "eo", "Afar", "Qafar", "ET" },
                    { 28, "th", "Thai", "ไทย", "TH" },
                    { 19, "vi", "Vietnamese", "Tiếng Việt", "VN" },
                    { 18, "ko", "Korean", "한국어", "KR" },
                    { 17, "cs", "Czech", "čeština", "CZ" },
                    { 2, "fr", "French", "français", "FR" },
                    { 3, "de", "German", "Deutsch", "DE" },
                    { 4, "ja", "Japanese", "日本語", "JP" },
                    { 5, "ru", "Russian", "русский", "RU" },
                    { 6, "it", "Italian", "italiano", "IT" },
                    { 7, "pt", "Portuguese", "português", "BR" },
                    { 8, "zh", "Chinese", "中文", "CN" },
                    { 9, "ar", "Arabic", "العربية", "SA" },
                    { 10, "fa", "Persian", "فارسی", "IR" },
                    { 11, "pl", "Polish", "polski", "PL" },
                    { 12, "nl", "Dutch", "Nederlands", "NL" },
                    { 13, "id", "Indonesian", "Indonesia", "ID" },
                    { 14, "uk", "Ukrainian", "українська", "UA" },
                    { 15, "he", "Hebrew", "עברית", "IL" },
                    { 16, "sv", "Swedish", "svenska", "SE" },
                    { 35, "lt", "Lithuanian", "lietuvių", "LT" },
                    { 145, "sgv", "Afar", "Qafar", "ET" },
                    { 36, "sk", "Slovak", "slovenčina", "SK" },
                    { 38, "sl", "Slovenian", "slovenščina", "SI" },
                    { 58, "br", "Breton", "brezhoneg", "FR" },
                    { 59, "mk", "Macedonian", "македонски", "MK" },
                    { 60, "lv", "Latvian", "latviešu", "LV" },
                    { 61, "mr", "Marathi", "मराठी", "IN" },
                    { 62, "cy", "Welsh", "Cymraeg", "GB" },
                    { 63, "ku", "Central Kurdish", "کوردیی ناوەڕاست", "IQ" },
                    { 57, "la", "Afar", "Qafar", "ET" },
                    { 64, "jv", "Javanese", "Basa Jawa", "ET" },
                    { 66, "hy", "Armenian", "Հայերեն", "AM" },
                    { 67, "sa", "Sanskrit", "संस्कृत", "IN" },
                    { 68, "as", "Assamese", "অসমীয়া", "IN" },
                    { 69, "my", "Burmese", "မြန်မာ", "MM" },
                    { 70, "kn", "Kannada", "ಕನ್ನಡ", "IN" },
                    { 71, "tt", "Tatar", "Татар", "RU" },
                    { 65, "ga", "Irish", "Gaeilge", "IE" },
                    { 56, "uz", "Uzbek", "o‘zbek", "UZ" },
                    { 55, "sq", "Albanian", "shqip", "AL" },
                    { 54, "is", "Icelandic", "íslenska", "IS" },
                    { 39, "eu", "Basque", "euskara", "ES" },
                    { 40, "et", "Estonian", "eesti", "EE" },
                    { 41, "hr", "Croatian", "hrvatski", "HR" },
                    { 42, "ms", "Malay", "Melayu", "MY" },
                    { 43, "ur", "Urdu", "اُردو", "PK" },
                    { 44, "ta", "Tamil", "தமிழ்", "IN" },
                    { 45, "te", "Telugu", "తెలుగు", "IN" },
                    { 46, "nn", "Norwegian Nynorsk", "nynorsk", "NO" },
                    { 47, "gl", "Galician", "galego", "ES" },
                    { 48, "af", "Afrikaans", "Afrikaans", "ZA" },
                    { 49, "bs", "Bosnian", "bosanski", "BA" },
                    { 50, "be", "Belarusian", "Беларуская", "BY" },
                    { 51, "lb", "Luxembourgish", "Lëtzebuergesch", "LU" },
                    { 52, "ml", "Malayalam", "മലയാളം", "IN" },
                    { 53, "ka", "Georgian", "ქართული", "GE" },
                    { 37, "bg", "Bulgarian", "български", "BG" },
                    { 146, "nqo", "N'ko", "ߒߞߏ", "ET" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 146);

            migrationBuilder.DropColumn(
                name: "NativeName",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "RegionCode",
                table: "Languages");

            migrationBuilder.AddColumn<int>(
                name: "LanguageFamilyId",
                table: "Languages",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LanguageFamilies",
                columns: table => new
                {
                    LanguageFamilyId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageFamilies", x => x.LanguageFamilyId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Languages_LanguageFamilyId",
                table: "Languages",
                column: "LanguageFamilyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_LanguageFamilies_LanguageFamilyId",
                table: "Languages",
                column: "LanguageFamilyId",
                principalTable: "LanguageFamilies",
                principalColumn: "LanguageFamilyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
