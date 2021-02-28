using Microsoft.EntityFrameworkCore.Migrations;

namespace IdiomsService.Migrations
{
    public partial class languagesInsert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "RegionCode",
                value: "GB");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 34,
                columns: new[] { "Name", "NativeName", "RegionCode" },
                values: new object[] { "Esperanto", "Esperanto", "EO" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 57,
                columns: new[] { "Name", "NativeName", "RegionCode" },
                values: new object[] { "Latin", "latīnum", "LA" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 74,
                column: "Locale",
                value: "aa");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 77,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "fy", "Western Frisian", "Frysk", "NL" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 78,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "mg", "Malagasy", "Malagasy", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 79,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "gd", "Scottish Gaelic", "Gàidhlig", "GB" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 80,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "pa", "Punjabi", "ਪੰਜਾਬੀ", "IN" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 81,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "sd", "Sindhi", "سنڌي", "PK" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 82,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "km", "Khmer", "ភាសាខ្មែរ", "KH" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 83,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "am", "Amharic", "አማርኛ", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 84,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "co", "Corsican", "Corsu", "FR" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 85,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "dv", "Divehi", "ދިވެހިބަސް", "MV" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 86,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "fo", "Faroese", "føroyskt", "FO" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 87,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "mi", "Maori", "te reo Māori", "NZ" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 88,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "mt", "Maltese", "Malti", "MT" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 89,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ne", "Nepali", "नेपाली", "NP" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 90,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "se", "Sami Northern", "davvisámegiella", "NO" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 91,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "qu", "Quechua", "Runasimi", "BO" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 92,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ps", "Pashto", "پښتو", "AF" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 93,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "rm", "Romansh", "rumantsch", "CH" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 94,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "si", "Sinhala", "සිංහල", "LK" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 95,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "tk", "Turkmen", "Türkmen dili", "TM" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 96,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "hsb", "Upper Sorbian", "hornjoserbšćina", "DE" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 97,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "yo", "Yoruba", "Èdè Yorùbá", "NG" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 98,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "haw", "Hawaiian", "ʻŌlelo Hawaiʻi", "US" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 99,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "wo", "Wolof", "Wolof", "SN" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 100,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ky", "Kyrgyz", "Кыргыз", "KG" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 101,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ig", "Igbo", "Igbo", "NG" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 102,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "or", "Odia", "ଓଡ଼ିଆ", "IN" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 103,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "gn", "Guarani", "Avañe’ẽ", "PY" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 104,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "so", "Somali", "Soomaali", "SO" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 105,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ug", "Uyghur", "ئۇيغۇرچە", "CN" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 106,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ha", "Hausa", "Hausa", "NG" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 107,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "sah", "Sakha", "Саха", "RU" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 108,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "sn", "Shona", "chiShona", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 109,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "lo", "Lao", "ລາວ", "LA" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 110,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "iu", "Inuktitut", "Inuktitut", "CA" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 111,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "bo", "Tibetan", "བོད་ཡིག", "CN" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 112,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "om", "Oromo", "Oromoo", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 113,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ti", "Tigrinya", "ትግርኛ", "ER" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 114,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "zu", "isiZulu", "isiZulu", "ZA" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 115,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "rw", "Kinyarwanda", "Kinyarwanda", "RW" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 116,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "xh", "isiXhosa", "isiXhosa", "ZA" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 117,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "kl", "Greenlandic", "kalaallisut", "GL" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 118,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ts", "Xitsonga", "Xitsonga", "ZA" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 119,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "st", "Sesotho", "Sesotho", "ZA" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 120,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ff", "Fulah", "Fulah", "SN" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 121,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "tn", "Setswana", "Setswana", "ZA" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 122,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "nqo", "N'ko", "ߒߞߏ", "ET" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "RegionCode",
                value: "US");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 34,
                columns: new[] { "Name", "NativeName", "RegionCode" },
                values: new object[] { "Afar", "Qafar", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 57,
                columns: new[] { "Name", "NativeName", "RegionCode" },
                values: new object[] { "Afar", "Qafar", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 74,
                column: "Locale",
                value: "nds");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 77,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ksh", "Afar", "Qafar", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 78,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "fy", "Western Frisian", "Frysk", "NL" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 79,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "yi", "Afar", "Qafar", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 80,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "mg", "Malagasy", "Malagasy", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 81,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "gd", "Scottish Gaelic", "Gàidhlig", "GB" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 82,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ce", "Afar", "Qafar", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 83,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "pa", "Punjabi", "ਪੰਜਾਬੀ", "IN" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 84,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "sd", "Sindhi", "سنڌي", "PK" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 85,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "km", "Khmer", "ភាសាខ្មែរ", "KH" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 86,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "am", "Amharic", "አማርኛ", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 87,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "co", "Corsican", "Corsu", "FR" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 88,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "dv", "Divehi", "ދިވެހިބަސް", "MV" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 89,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "fo", "Faroese", "føroyskt", "FO" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 90,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "fur", "Afar", "Qafar", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 91,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "gv", "Afar", "Qafar", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 92,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "mi", "Maori", "te reo Māori", "NZ" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 93,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "mt", "Maltese", "Malti", "MT" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 94,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ne", "Nepali", "नेपाली", "NP" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 95,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "se", "Sami Northern", "davvisámegiella", "NO" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 96,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "qu", "Quechua", "Runasimi", "BO" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 97,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "os", "Afar", "Qafar", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 98,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ps", "Pashto", "پښتو", "AF" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 99,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "rm", "Romansh", "rumantsch", "CH" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 100,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "si", "Sinhala", "සිංහල", "LK" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 101,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "to", "Afar", "Qafar", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 102,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "tk", "Turkmen", "Türkmen dili", "TM" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 103,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "hsb", "Upper Sorbian", "hornjoserbšćina", "DE" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 104,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "yo", "Yoruba", "Èdè Yorùbá", "NG" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 105,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "kw", "Afar", "Qafar", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 106,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "haw", "Hawaiian", "ʻŌlelo Hawaiʻi", "US" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 107,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ln", "Afar", "Qafar", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 108,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "wo", "Wolof", "Wolof", "SN" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 109,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ky", "Kyrgyz", "Кыргыз", "KG" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 110,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ig", "Igbo", "Igbo", "NG" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 111,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "or", "Odia", "ଓଡ଼ିଆ", "IN" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 112,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "gn", "Guarani", "Avañe’ẽ", "PY" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 113,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "so", "Somali", "Soomaali", "SO" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 114,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "kab", "Afar", "Qafar", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 115,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ug", "Uyghur", "ئۇيغۇرچە", "CN" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 116,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ha", "Hausa", "Hausa", "NG" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 117,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "mzn", "Afar", "Qafar", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 118,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "pap", "Afar", "Qafar", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 119,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "cu", "Afar", "Qafar", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 120,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "sah", "Sakha", "Саха", "RU" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 121,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "sn", "Shona", "chiShona", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 122,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "lo", "Lao", "ລາວ", "LA" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[,]
                {
                    { 145, "sgv", "Afar", "Qafar", "ET" },
                    { 124, "bo", "Tibetan", "བོད་ཡིག", "CN" },
                    { 125, "om", "Oromo", "Oromoo", "ET" },
                    { 126, "ee", "Afar", "Qafar", "ET" },
                    { 127, "ti", "Tigrinya", "ትግርኛ", "ER" },
                    { 128, "bm", "Afar", "Qafar", "ET" },
                    { 129, "zu", "isiZulu", "isiZulu", "ZA" },
                    { 130, "ss", "Afar", "Qafar", "ET" },
                    { 131, "rw", "Kinyarwanda", "Kinyarwanda", "RW" },
                    { 132, "xh", "isiXhosa", "isiXhosa", "ZA" },
                    { 133, "kl", "Greenlandic", "kalaallisut", "GL" },
                    { 134, "dz", "Afar", "Qafar", "ET" },
                    { 135, "ts", "Xitsonga", "Xitsonga", "ZA" },
                    { 136, "st", "Sesotho", "Sesotho", "ZA" },
                    { 137, "ak", "Afar", "Qafar", "ET" },
                    { 138, "ks", "Afar", "Qafar", "ET" },
                    { 139, "ff", "Fulah", "Fulah", "SN" },
                    { 140, "lg", "Afar", "Qafar", "ET" },
                    { 141, "rny", "Afar", "Qafar", "ET" },
                    { 142, "ve", "Afar", "Qafar", "ET" },
                    { 143, "tn", "Setswana", "Setswana", "ZA" },
                    { 144, "ki", "Afar", "Qafar", "ET" },
                    { 146, "nqo", "N'ko", "ߒߞߏ", "ET" },
                    { 123, "iu", "Inuktitut", "Inuktitut", "CA" }
                });
        }
    }
}
