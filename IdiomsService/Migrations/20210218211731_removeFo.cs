using Microsoft.EntityFrameworkCore.Migrations;

namespace IdiomsService.Migrations
{
    public partial class removeFo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 122);

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 86,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "mi", "Maori", "te reo Māori", "NZ" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 87,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "mt", "Maltese", "Malti", "MT" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 88,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ne", "Nepali", "नेपाली", "NP" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 89,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "se", "Sami Northern", "davvisámegiella", "NO" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 90,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "qu", "Quechua", "Runasimi", "BO" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 91,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ps", "Pashto", "پښتو", "AF" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 92,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "rm", "Romansh", "rumantsch", "CH" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 93,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "si", "Sinhala", "සිංහල", "LK" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 94,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "tk", "Turkmen", "Türkmen dili", "TM" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 95,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "hsb", "Upper Sorbian", "hornjoserbšćina", "DE" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 96,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "yo", "Yoruba", "Èdè Yorùbá", "NG" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 97,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "haw", "Hawaiian", "ʻŌlelo Hawaiʻi", "US" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 98,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "wo", "Wolof", "Wolof", "SN" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 99,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ky", "Kyrgyz", "Кыргыз", "KG" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 100,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ig", "Igbo", "Igbo", "NG" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 101,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "or", "Odia", "ଓଡ଼ିଆ", "IN" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 102,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "gn", "Guarani", "Avañe’ẽ", "PY" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 103,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "so", "Somali", "Soomaali", "SO" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 104,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ug", "Uyghur", "ئۇيغۇرچە", "CN" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 105,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ha", "Hausa", "Hausa", "NG" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 106,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "sah", "Sakha", "Саха", "RU" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 107,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "sn", "Shona", "chiShona", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 108,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "lo", "Lao", "ລາວ", "LA" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 109,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "iu", "Inuktitut", "Inuktitut", "CA" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 110,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "bo", "Tibetan", "བོད་ཡིག", "CN" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 111,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "om", "Oromo", "Oromoo", "ET" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 112,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ti", "Tigrinya", "ትግርኛ", "ER" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 113,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "zu", "isiZulu", "isiZulu", "ZA" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 114,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "rw", "Kinyarwanda", "Kinyarwanda", "RW" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 115,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "xh", "isiXhosa", "isiXhosa", "ZA" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 116,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "kl", "Greenlandic", "kalaallisut", "GL" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 117,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ts", "Xitsonga", "Xitsonga", "ZA" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 118,
                columns: new[] { "Locale", "Name", "NativeName" },
                values: new object[] { "st", "Sesotho", "Sesotho" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 119,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "ff", "Fulah", "Fulah", "SN" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 120,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "tn", "Setswana", "Setswana", "ZA" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 121,
                columns: new[] { "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { "nqo", "N'ko", "ߒߞߏ", "ET" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Locale", "Name", "NativeName" },
                values: new object[] { "ts", "Xitsonga", "Xitsonga" });

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

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Locale", "Name", "NativeName", "RegionCode" },
                values: new object[] { 122, "nqo", "N'ko", "ߒߞߏ", "ET" });
        }
    }
}
