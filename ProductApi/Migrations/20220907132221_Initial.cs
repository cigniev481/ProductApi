using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { "4b0b44ee-eda0-4864-a424-47a95c0b26b6", "6/5/2011", false, "Jakie", 0m },
                    { "0a782c84-7975-4f6e-b0ae-dff15a66d38d", "9/11/2001", true, "Willa", 0m },
                    { "906674b1-cb9f-4a27-b564-123f9d53df9d", "7/25/2009", true, "Hershel", 0m },
                    { "eac60b58-5df6-4675-9cd5-dc0a24fe5153", "8/5/2018", false, "Emlyn", 0m },
                    { "d70f2b80-21dc-4d60-a283-f2ee9afef5bd", "3/5/2003", false, "Roslyn", 0m },
                    { "aac39f8e-95a0-4139-96af-c807c3ede9d7", "2/5/2009", true, "Jilli", 0m },
                    { "2c20eb70-6008-43ef-8808-a816057157f9", "8/25/2017", false, "Sephira", 0m },
                    { "9f68b61d-6e38-46a0-884c-6ed7bc189de6", "11/13/2003", true, "Sigrid", 0m },
                    { "2ef237f7-f1b2-4d96-aa4b-6f809177e1a5", "9/18/2013", true, "Melesa", 0m },
                    { "2fd0fec5-5955-47a8-a81f-d11cdc92d012", "5/13/2017", true, "Tait", 0m },
                    { "eb92f208-26df-47fc-9370-9f114e2e5df5", "11/3/2003", false, "Dorri", 0m },
                    { "0e24dc3a-f20e-4725-a6f9-a13e4113fb6e", "1/29/2016", false, "Gerri", 0m },
                    { "aba95a08-feb2-42b3-a38f-03985704ce74", "5/15/2002", true, "Maressa", 0m },
                    { "9b81f400-6869-4164-a71e-1337068351c0", "7/25/2009", true, "Gates", 0m },
                    { "dcd72034-7c4a-438c-a3a5-ad7374cc8261", "8/19/2018", true, "Wright", 0m },
                    { "3f11a19d-cfc9-438f-ae6e-be45d5f99d6c", "9/6/2017", false, "Barbara-anne", 0m },
                    { "592058e6-c136-4b8d-a2ae-741ee23deea8", "6/29/2016", false, "Bunni", 0m },
                    { "1b6102a1-6850-4cd9-baec-a2c9c211d79f", "1/28/2008", false, "Archer", 0m },
                    { "ff1796ea-55e1-40b7-bd37-281bd20425ea", "12/25/2015", true, "Zitella", 0m },
                    { "b1c87c7b-c543-4094-966b-bd4ca1bae13a", "7/22/2003", false, "Jeri", 0m },
                    { "ace9c615-2a0d-4ddf-9d1d-9d5497ae6e51", "4/26/2017", false, "Missie", 0m },
                    { "78a0e13a-212c-4ca1-b08c-6f96ec925880", "6/1/2005", false, "Lucina", 0m },
                    { "c4c47ca8-0d15-4b85-b089-c9cde0234b81", "5/23/2013", false, "Brendon", 0m },
                    { "0d44f42e-21fc-46b0-9ea6-89ec36d8693c", "2/2/2005", false, "Nisse", 0m },
                    { "57b216bc-30a0-4bc7-93d3-5a919333e0d1", "8/22/2019", false, "Mendel", 0m },
                    { "4d66f81d-3fd9-4dd5-86a4-9e0c59e1a11f", "12/5/2014", false, "Dewie", 0m },
                    { "8bfe4dde-d21c-46fb-88c8-12b7f800eec2", "4/28/2013", false, "Holden", 0m },
                    { "df01593d-fb40-454a-98ce-30632da1cda6", "10/11/2013", true, "Amie", 0m },
                    { "96a05055-f04d-4d87-a2c0-22fda27a97d1", "11/17/2013", false, "Kiel", 0m },
                    { "70389de8-8179-4959-a701-dc18b6cbc2d0", "8/20/2016", true, "Amalita", 0m },
                    { "684a5512-c8db-4bfc-82b8-d1100ffd1e13", "1/30/2006", true, "Bertram", 0m },
                    { "045d6244-029b-45eb-acf9-9a807b91da30", "1/8/2009", false, "Enrico", 0m },
                    { "d630204f-183d-4700-a060-991df04c6f5b", "2/27/2018", false, "Gloriana", 0m },
                    { "502beee2-2478-47bf-bce6-fefe53eeb447", "2/16/2016", false, "Forrester", 0m },
                    { "c4fbc0b1-0705-486e-b908-d59b014921fb", "1/1/2005", false, "Chuck", 0m },
                    { "efbbf66c-d577-4222-82b3-0c50d56c207a", "8/22/2009", false, "Richy", 0m },
                    { "26769601-30ce-472a-b73e-bf9acd522194", "6/28/2016", true, "Clevey", 0m },
                    { "40aff1e5-2dcb-4fea-baa0-bc5db83bb74d", "4/1/2016", true, "Cly", 0m },
                    { "cfb4f644-ff2a-495d-a258-470dd5fffee3", "7/18/2014", true, "Gerik", 0m },
                    { "366442da-d2fd-4d32-955d-c473cb795454", "10/24/2001", true, "Orsa", 0m },
                    { "9330a823-6f8d-4ed0-b620-fdf3dbadcbd8", "4/19/2005", false, "Ira", 0m },
                    { "d21eab2d-702a-4123-889b-6b2cb3d9a930", "2/22/2011", false, "Bibbie", 0m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { "0fa79e3f-bb5e-4466-aefa-c484169cbc40", "5/8/2013", false, "Nikola", 0m },
                    { "7e166282-811b-420c-a194-4496feb11f3d", "1/21/2008", true, "Aubine", 0m },
                    { "5680d15a-34d7-43d1-834e-e1f25f83c0e9", "5/30/2005", false, "Nadeen", 0m },
                    { "b3b4c787-f644-4bd9-b124-df7eca9b3bf9", "3/7/2005", true, "Karie", 0m },
                    { "4084c7bd-b6d7-4134-a917-4910f75a779f", "2/19/2003", false, "Teddi", 0m },
                    { "759df1f4-7d6c-4fb8-9841-0b9f9a47c850", "12/5/2011", false, "Marven", 0m },
                    { "3d00d6f5-6444-4efa-a478-a5c4d3d85c06", "8/31/2019", true, "Ario", 0m },
                    { "49d3a11a-56b3-49a5-828f-c67ccc8f4aff", "11/9/2011", true, "Johnathan", 0m },
                    { "bff182ed-ae8d-4a86-ab4e-0f8a7844407a", "2/19/2006", false, "Bernice", 0m },
                    { "155a607f-004e-46e1-a23d-407a93191a29", "6/27/2015", true, "Annalise", 0m },
                    { "19c0cdb4-ed96-4011-b8e1-8b8ff5ddc2d3", "5/13/2011", true, "Sasha", 0m },
                    { "3bcd8bea-a4fa-4ddf-bbc8-b36790111b6b", "11/17/2001", true, "Brocky", 0m },
                    { "6577307f-373b-41ea-b81c-2b6053e419de", "7/16/2015", true, "Any", 0m },
                    { "24ba9185-4670-40c5-9124-3fd6d1e6407d", "7/24/2005", true, "Cecilio", 0m },
                    { "8c9d1b5c-d54f-4385-8005-312e01b74079", "10/24/2017", false, "See", 0m },
                    { "b516fc0c-9bd9-4927-842b-afec0ec95638", "2/25/2019", false, "Emmett", 0m },
                    { "b4534e11-165d-409f-aadb-6bf405a90acd", "2/15/2017", false, "Bart", 0m },
                    { "2f7dcc95-636c-41da-8130-43394f43c6a4", "10/25/2011", false, "Datha", 0m },
                    { "1b8c8a9b-9316-450b-bc1f-bd545d9d8d76", "9/9/2009", false, "Joyan", 0m },
                    { "61a22dac-1da0-4721-a80e-0982678cfb71", "11/17/2017", false, "Gay", 0m },
                    { "1489dd78-f2a4-40f4-81a1-57b1e674de46", "11/26/2015", false, "Hertha", 0m },
                    { "b627daa1-7518-4508-b7f8-7f7f44861d9c", "12/22/2017", true, "Torin", 0m },
                    { "243cbbd7-69f7-4bfe-84e6-df0d7a4ba8ae", "6/23/2011", true, "Peyter", 0m },
                    { "cb84893f-0a38-4d00-8007-b2ca793c4c30", "3/3/2010", false, "Fairlie", 0m },
                    { "045ef477-bfae-439f-86fc-bf9f5739c10a", "8/2/2014", true, "Riordan", 0m },
                    { "b4dd930f-2b81-4cc3-a190-cc39b5ef251c", "7/11/2005", false, "Remy", 0m },
                    { "bc50c3ba-1bae-4262-bd0a-9557a33906c9", "3/28/2004", false, "Rochell", 0m },
                    { "9dba12cd-a5ff-4d7f-a38d-938ad0f2be68", "1/22/2008", false, "Josselyn", 0m },
                    { "a3921e3b-9ea7-4bd4-860b-3c72dc0a7c7f", "6/2/2007", false, "Dieter", 0m },
                    { "a4422765-39b1-4fa3-b8f4-bdd93762a6c3", "1/5/2014", true, "Karoly", 0m },
                    { "d1a53caf-f086-4aba-9b23-745e5bb80fa8", "6/17/2015", true, "Anita", 0m },
                    { "5a0fb8fc-970f-4463-98a5-fd7e1ef4ff9e", "7/28/2015", false, "Cloe", 0m },
                    { "21ed6f26-eb35-426a-8dae-ea21fd719449", "7/20/2011", true, "Ashlie", 0m },
                    { "4dff8971-4e62-4c9f-9ac6-c541db4de59c", "4/13/2017", false, "Gwen", 0m },
                    { "1384c49a-a812-43be-978c-785e0ff16408", "8/21/2012", false, "Dermot", 0m },
                    { "cac710f7-7d75-4a60-a497-d5cec50cb0f8", "10/24/2006", true, "Hatty", 0m },
                    { "12b8bd31-9981-4377-bc36-57c287d4fa6d", "11/2/2001", true, "Celene", 0m },
                    { "6aeaa875-b413-4173-a77a-a4cb2d61c7c4", "12/21/2003", true, "Pierce", 0m },
                    { "8ddba754-b6ba-4902-bcf2-fba560e3531b", "5/4/2006", false, "Arda", 0m },
                    { "cbd3e8e8-60c4-4f48-ac70-9efc223fa1df", "9/27/2003", false, "Ferdy", 0m },
                    { "1ac26a4c-1c7c-4702-a19d-09da3ce93969", "9/23/2014", false, "Jacqueline", 0m },
                    { "e387f855-414a-439b-9bf5-0c726b2efa34", "3/25/2019", true, "Yves", 0m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { "ce8c1682-1e1f-424a-ab92-ae08c5803bee", "4/6/2008", true, "Marcellus", 0m },
                    { "db4ec595-eb8c-4168-a608-b733c17f0cc3", "12/25/2006", true, "Blondelle", 0m },
                    { "95fbbb4c-143e-4e26-a9b2-0dacaece76f5", "7/16/2002", true, "Loree", 0m },
                    { "1e2441fd-49de-4ca6-b092-2c42da2831ae", "12/21/2002", true, "Margit", 0m },
                    { "e71c28bc-baeb-4c61-afe1-e06f7ffa2095", "8/6/2011", true, "Aldus", 0m },
                    { "14442277-3ed7-47ba-9e17-c453878e6e8f", "1/16/2003", true, "Adelaide", 0m },
                    { "d9a938f6-19c7-4407-b071-f0078a1c2c19", "9/1/2008", true, "Jon", 0m },
                    { "f573b40f-4635-4740-a7aa-e18bc5d6c637", "3/29/2007", false, "Bart", 0m },
                    { "861e5df9-1645-4e22-8cb6-954da355e312", "11/12/2002", true, "Hurley", 0m },
                    { "3e0fc480-4b97-4d01-939d-695ec2312104", "9/30/2007", true, "Ardenia", 0m },
                    { "d524f24e-acf5-4362-b183-4711c5283323", "10/8/2005", true, "Duke", 0m },
                    { "ff12eb7e-5cee-4472-bff8-fc0ba6e11092", "12/3/2001", false, "Emile", 0m },
                    { "068be027-f5ff-4fd5-9033-8bb6f921c4a7", "9/15/2004", true, "Lay", 0m },
                    { "1a135ed9-d932-4524-9791-f9792b25f82e", "6/9/2014", true, "Ara", 0m },
                    { "e59d863a-0298-4cc6-8357-6a91d5249ec4", "2/13/2008", false, "Shela", 0m },
                    { "2e333162-e295-45b1-8fea-9364ff006c62", "8/3/2009", false, "Mikey", 0m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
