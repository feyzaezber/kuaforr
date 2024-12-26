using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kuaforr.Migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminIsim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoyIsim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminSifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Iletisims",
                columns: table => new
                {
                    IletisimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IletisimAdresi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IletisimMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IletisimTelefon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisims", x => x.IletisimId);
                });

            migrationBuilder.CreateTable(
                name: "Randevus",
                columns: table => new
                {
                    RandevuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RandevuIsimSoyisim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RandevuSaati = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RandevuTarihi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalisanId = table.Column<int>(type: "int", nullable: false),
                    HizmetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevus", x => x.RandevuId);
                });

            migrationBuilder.CreateTable(
                name: "Calisanlarimizs",
                columns: table => new
                {
                    CalisanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalisanIsim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalisanSoyisim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalisanFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalisanMaas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HizmetId = table.Column<int>(type: "int", nullable: false),
                    RandevuId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calisanlarimizs", x => x.CalisanId);
                    table.ForeignKey(
                        name: "FK_Calisanlarimizs_Randevus_RandevuId",
                        column: x => x.RandevuId,
                        principalTable: "Randevus",
                        principalColumn: "RandevuId");
                });

            migrationBuilder.CreateTable(
                name: "Hizmetlerimizs",
                columns: table => new
                {
                    HizmetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HizmetIsim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HizmetUcret = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HizmetFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalisanlarimizCalisanId = table.Column<int>(type: "int", nullable: true),
                    RandevuId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hizmetlerimizs", x => x.HizmetId);
                    table.ForeignKey(
                        name: "FK_Hizmetlerimizs_Calisanlarimizs_CalisanlarimizCalisanId",
                        column: x => x.CalisanlarimizCalisanId,
                        principalTable: "Calisanlarimizs",
                        principalColumn: "CalisanId");
                    table.ForeignKey(
                        name: "FK_Hizmetlerimizs_Randevus_RandevuId",
                        column: x => x.RandevuId,
                        principalTable: "Randevus",
                        principalColumn: "RandevuId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calisanlarimizs_RandevuId",
                table: "Calisanlarimizs",
                column: "RandevuId");

            migrationBuilder.CreateIndex(
                name: "IX_Hizmetlerimizs_CalisanlarimizCalisanId",
                table: "Hizmetlerimizs",
                column: "CalisanlarimizCalisanId");

            migrationBuilder.CreateIndex(
                name: "IX_Hizmetlerimizs_RandevuId",
                table: "Hizmetlerimizs",
                column: "RandevuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Hizmetlerimizs");

            migrationBuilder.DropTable(
                name: "Iletisims");

            migrationBuilder.DropTable(
                name: "Calisanlarimizs");

            migrationBuilder.DropTable(
                name: "Randevus");
        }
    }
}
