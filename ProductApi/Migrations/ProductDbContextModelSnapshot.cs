// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductApi.Models;

namespace ProductApi.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    partial class ProductDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProductApi.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasMaxLength(100)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = "4b0b44ee-eda0-4864-a424-47a95c0b26b6",
                            CreatedDate = "6/5/2011",
                            IsDeleted = false,
                            Name = "Jakie",
                            Price = 0m
                        },
                        new
                        {
                            Id = "a4422765-39b1-4fa3-b8f4-bdd93762a6c3",
                            CreatedDate = "1/5/2014",
                            IsDeleted = true,
                            Name = "Karoly",
                            Price = 0m
                        },
                        new
                        {
                            Id = "a3921e3b-9ea7-4bd4-860b-3c72dc0a7c7f",
                            CreatedDate = "6/2/2007",
                            IsDeleted = false,
                            Name = "Dieter",
                            Price = 0m
                        },
                        new
                        {
                            Id = "9dba12cd-a5ff-4d7f-a38d-938ad0f2be68",
                            CreatedDate = "1/22/2008",
                            IsDeleted = false,
                            Name = "Josselyn",
                            Price = 0m
                        },
                        new
                        {
                            Id = "bc50c3ba-1bae-4262-bd0a-9557a33906c9",
                            CreatedDate = "3/28/2004",
                            IsDeleted = false,
                            Name = "Rochell",
                            Price = 0m
                        },
                        new
                        {
                            Id = "b4dd930f-2b81-4cc3-a190-cc39b5ef251c",
                            CreatedDate = "7/11/2005",
                            IsDeleted = false,
                            Name = "Remy",
                            Price = 0m
                        },
                        new
                        {
                            Id = "045ef477-bfae-439f-86fc-bf9f5739c10a",
                            CreatedDate = "8/2/2014",
                            IsDeleted = true,
                            Name = "Riordan",
                            Price = 0m
                        },
                        new
                        {
                            Id = "cb84893f-0a38-4d00-8007-b2ca793c4c30",
                            CreatedDate = "3/3/2010",
                            IsDeleted = false,
                            Name = "Fairlie",
                            Price = 0m
                        },
                        new
                        {
                            Id = "243cbbd7-69f7-4bfe-84e6-df0d7a4ba8ae",
                            CreatedDate = "6/23/2011",
                            IsDeleted = true,
                            Name = "Peyter",
                            Price = 0m
                        },
                        new
                        {
                            Id = "b627daa1-7518-4508-b7f8-7f7f44861d9c",
                            CreatedDate = "12/22/2017",
                            IsDeleted = true,
                            Name = "Torin",
                            Price = 0m
                        },
                        new
                        {
                            Id = "1489dd78-f2a4-40f4-81a1-57b1e674de46",
                            CreatedDate = "11/26/2015",
                            IsDeleted = false,
                            Name = "Hertha",
                            Price = 0m
                        },
                        new
                        {
                            Id = "61a22dac-1da0-4721-a80e-0982678cfb71",
                            CreatedDate = "11/17/2017",
                            IsDeleted = false,
                            Name = "Gay",
                            Price = 0m
                        },
                        new
                        {
                            Id = "1b8c8a9b-9316-450b-bc1f-bd545d9d8d76",
                            CreatedDate = "9/9/2009",
                            IsDeleted = false,
                            Name = "Joyan",
                            Price = 0m
                        },
                        new
                        {
                            Id = "2f7dcc95-636c-41da-8130-43394f43c6a4",
                            CreatedDate = "10/25/2011",
                            IsDeleted = false,
                            Name = "Datha",
                            Price = 0m
                        },
                        new
                        {
                            Id = "b4534e11-165d-409f-aadb-6bf405a90acd",
                            CreatedDate = "2/15/2017",
                            IsDeleted = false,
                            Name = "Bart",
                            Price = 0m
                        },
                        new
                        {
                            Id = "b516fc0c-9bd9-4927-842b-afec0ec95638",
                            CreatedDate = "2/25/2019",
                            IsDeleted = false,
                            Name = "Emmett",
                            Price = 0m
                        },
                        new
                        {
                            Id = "8c9d1b5c-d54f-4385-8005-312e01b74079",
                            CreatedDate = "10/24/2017",
                            IsDeleted = false,
                            Name = "See",
                            Price = 0m
                        },
                        new
                        {
                            Id = "24ba9185-4670-40c5-9124-3fd6d1e6407d",
                            CreatedDate = "7/24/2005",
                            IsDeleted = true,
                            Name = "Cecilio",
                            Price = 0m
                        },
                        new
                        {
                            Id = "6577307f-373b-41ea-b81c-2b6053e419de",
                            CreatedDate = "7/16/2015",
                            IsDeleted = true,
                            Name = "Any",
                            Price = 0m
                        },
                        new
                        {
                            Id = "3bcd8bea-a4fa-4ddf-bbc8-b36790111b6b",
                            CreatedDate = "11/17/2001",
                            IsDeleted = true,
                            Name = "Brocky",
                            Price = 0m
                        },
                        new
                        {
                            Id = "19c0cdb4-ed96-4011-b8e1-8b8ff5ddc2d3",
                            CreatedDate = "5/13/2011",
                            IsDeleted = true,
                            Name = "Sasha",
                            Price = 0m
                        },
                        new
                        {
                            Id = "155a607f-004e-46e1-a23d-407a93191a29",
                            CreatedDate = "6/27/2015",
                            IsDeleted = true,
                            Name = "Annalise",
                            Price = 0m
                        },
                        new
                        {
                            Id = "d1a53caf-f086-4aba-9b23-745e5bb80fa8",
                            CreatedDate = "6/17/2015",
                            IsDeleted = true,
                            Name = "Anita",
                            Price = 0m
                        },
                        new
                        {
                            Id = "5a0fb8fc-970f-4463-98a5-fd7e1ef4ff9e",
                            CreatedDate = "7/28/2015",
                            IsDeleted = false,
                            Name = "Cloe",
                            Price = 0m
                        },
                        new
                        {
                            Id = "21ed6f26-eb35-426a-8dae-ea21fd719449",
                            CreatedDate = "7/20/2011",
                            IsDeleted = true,
                            Name = "Ashlie",
                            Price = 0m
                        },
                        new
                        {
                            Id = "4dff8971-4e62-4c9f-9ac6-c541db4de59c",
                            CreatedDate = "4/13/2017",
                            IsDeleted = false,
                            Name = "Gwen",
                            Price = 0m
                        },
                        new
                        {
                            Id = "1a135ed9-d932-4524-9791-f9792b25f82e",
                            CreatedDate = "6/9/2014",
                            IsDeleted = true,
                            Name = "Ara",
                            Price = 0m
                        },
                        new
                        {
                            Id = "068be027-f5ff-4fd5-9033-8bb6f921c4a7",
                            CreatedDate = "9/15/2004",
                            IsDeleted = true,
                            Name = "Lay",
                            Price = 0m
                        },
                        new
                        {
                            Id = "ff12eb7e-5cee-4472-bff8-fc0ba6e11092",
                            CreatedDate = "12/3/2001",
                            IsDeleted = false,
                            Name = "Emile",
                            Price = 0m
                        },
                        new
                        {
                            Id = "d524f24e-acf5-4362-b183-4711c5283323",
                            CreatedDate = "10/8/2005",
                            IsDeleted = true,
                            Name = "Duke",
                            Price = 0m
                        },
                        new
                        {
                            Id = "3e0fc480-4b97-4d01-939d-695ec2312104",
                            CreatedDate = "9/30/2007",
                            IsDeleted = true,
                            Name = "Ardenia",
                            Price = 0m
                        },
                        new
                        {
                            Id = "861e5df9-1645-4e22-8cb6-954da355e312",
                            CreatedDate = "11/12/2002",
                            IsDeleted = true,
                            Name = "Hurley",
                            Price = 0m
                        },
                        new
                        {
                            Id = "f573b40f-4635-4740-a7aa-e18bc5d6c637",
                            CreatedDate = "3/29/2007",
                            IsDeleted = false,
                            Name = "Bart",
                            Price = 0m
                        },
                        new
                        {
                            Id = "d9a938f6-19c7-4407-b071-f0078a1c2c19",
                            CreatedDate = "9/1/2008",
                            IsDeleted = true,
                            Name = "Jon",
                            Price = 0m
                        },
                        new
                        {
                            Id = "14442277-3ed7-47ba-9e17-c453878e6e8f",
                            CreatedDate = "1/16/2003",
                            IsDeleted = true,
                            Name = "Adelaide",
                            Price = 0m
                        },
                        new
                        {
                            Id = "e71c28bc-baeb-4c61-afe1-e06f7ffa2095",
                            CreatedDate = "8/6/2011",
                            IsDeleted = true,
                            Name = "Aldus",
                            Price = 0m
                        },
                        new
                        {
                            Id = "e59d863a-0298-4cc6-8357-6a91d5249ec4",
                            CreatedDate = "2/13/2008",
                            IsDeleted = false,
                            Name = "Shela",
                            Price = 0m
                        },
                        new
                        {
                            Id = "1e2441fd-49de-4ca6-b092-2c42da2831ae",
                            CreatedDate = "12/21/2002",
                            IsDeleted = true,
                            Name = "Margit",
                            Price = 0m
                        },
                        new
                        {
                            Id = "db4ec595-eb8c-4168-a608-b733c17f0cc3",
                            CreatedDate = "12/25/2006",
                            IsDeleted = true,
                            Name = "Blondelle",
                            Price = 0m
                        },
                        new
                        {
                            Id = "ce8c1682-1e1f-424a-ab92-ae08c5803bee",
                            CreatedDate = "4/6/2008",
                            IsDeleted = true,
                            Name = "Marcellus",
                            Price = 0m
                        },
                        new
                        {
                            Id = "e387f855-414a-439b-9bf5-0c726b2efa34",
                            CreatedDate = "3/25/2019",
                            IsDeleted = true,
                            Name = "Yves",
                            Price = 0m
                        },
                        new
                        {
                            Id = "1ac26a4c-1c7c-4702-a19d-09da3ce93969",
                            CreatedDate = "9/23/2014",
                            IsDeleted = false,
                            Name = "Jacqueline",
                            Price = 0m
                        },
                        new
                        {
                            Id = "cbd3e8e8-60c4-4f48-ac70-9efc223fa1df",
                            CreatedDate = "9/27/2003",
                            IsDeleted = false,
                            Name = "Ferdy",
                            Price = 0m
                        },
                        new
                        {
                            Id = "8ddba754-b6ba-4902-bcf2-fba560e3531b",
                            CreatedDate = "5/4/2006",
                            IsDeleted = false,
                            Name = "Arda",
                            Price = 0m
                        },
                        new
                        {
                            Id = "6aeaa875-b413-4173-a77a-a4cb2d61c7c4",
                            CreatedDate = "12/21/2003",
                            IsDeleted = true,
                            Name = "Pierce",
                            Price = 0m
                        },
                        new
                        {
                            Id = "12b8bd31-9981-4377-bc36-57c287d4fa6d",
                            CreatedDate = "11/2/2001",
                            IsDeleted = true,
                            Name = "Celene",
                            Price = 0m
                        },
                        new
                        {
                            Id = "cac710f7-7d75-4a60-a497-d5cec50cb0f8",
                            CreatedDate = "10/24/2006",
                            IsDeleted = true,
                            Name = "Hatty",
                            Price = 0m
                        },
                        new
                        {
                            Id = "1384c49a-a812-43be-978c-785e0ff16408",
                            CreatedDate = "8/21/2012",
                            IsDeleted = false,
                            Name = "Dermot",
                            Price = 0m
                        },
                        new
                        {
                            Id = "bff182ed-ae8d-4a86-ab4e-0f8a7844407a",
                            CreatedDate = "2/19/2006",
                            IsDeleted = false,
                            Name = "Bernice",
                            Price = 0m
                        },
                        new
                        {
                            Id = "49d3a11a-56b3-49a5-828f-c67ccc8f4aff",
                            CreatedDate = "11/9/2011",
                            IsDeleted = true,
                            Name = "Johnathan",
                            Price = 0m
                        },
                        new
                        {
                            Id = "3d00d6f5-6444-4efa-a478-a5c4d3d85c06",
                            CreatedDate = "8/31/2019",
                            IsDeleted = true,
                            Name = "Ario",
                            Price = 0m
                        },
                        new
                        {
                            Id = "0d44f42e-21fc-46b0-9ea6-89ec36d8693c",
                            CreatedDate = "2/2/2005",
                            IsDeleted = false,
                            Name = "Nisse",
                            Price = 0m
                        },
                        new
                        {
                            Id = "78a0e13a-212c-4ca1-b08c-6f96ec925880",
                            CreatedDate = "6/1/2005",
                            IsDeleted = false,
                            Name = "Lucina",
                            Price = 0m
                        },
                        new
                        {
                            Id = "ace9c615-2a0d-4ddf-9d1d-9d5497ae6e51",
                            CreatedDate = "4/26/2017",
                            IsDeleted = false,
                            Name = "Missie",
                            Price = 0m
                        },
                        new
                        {
                            Id = "b1c87c7b-c543-4094-966b-bd4ca1bae13a",
                            CreatedDate = "7/22/2003",
                            IsDeleted = false,
                            Name = "Jeri",
                            Price = 0m
                        },
                        new
                        {
                            Id = "ff1796ea-55e1-40b7-bd37-281bd20425ea",
                            CreatedDate = "12/25/2015",
                            IsDeleted = true,
                            Name = "Zitella",
                            Price = 0m
                        },
                        new
                        {
                            Id = "1b6102a1-6850-4cd9-baec-a2c9c211d79f",
                            CreatedDate = "1/28/2008",
                            IsDeleted = false,
                            Name = "Archer",
                            Price = 0m
                        },
                        new
                        {
                            Id = "592058e6-c136-4b8d-a2ae-741ee23deea8",
                            CreatedDate = "6/29/2016",
                            IsDeleted = false,
                            Name = "Bunni",
                            Price = 0m
                        },
                        new
                        {
                            Id = "3f11a19d-cfc9-438f-ae6e-be45d5f99d6c",
                            CreatedDate = "9/6/2017",
                            IsDeleted = false,
                            Name = "Barbara-anne",
                            Price = 0m
                        },
                        new
                        {
                            Id = "dcd72034-7c4a-438c-a3a5-ad7374cc8261",
                            CreatedDate = "8/19/2018",
                            IsDeleted = true,
                            Name = "Wright",
                            Price = 0m
                        },
                        new
                        {
                            Id = "9b81f400-6869-4164-a71e-1337068351c0",
                            CreatedDate = "7/25/2009",
                            IsDeleted = true,
                            Name = "Gates",
                            Price = 0m
                        },
                        new
                        {
                            Id = "aba95a08-feb2-42b3-a38f-03985704ce74",
                            CreatedDate = "5/15/2002",
                            IsDeleted = true,
                            Name = "Maressa",
                            Price = 0m
                        },
                        new
                        {
                            Id = "0e24dc3a-f20e-4725-a6f9-a13e4113fb6e",
                            CreatedDate = "1/29/2016",
                            IsDeleted = false,
                            Name = "Gerri",
                            Price = 0m
                        },
                        new
                        {
                            Id = "eb92f208-26df-47fc-9370-9f114e2e5df5",
                            CreatedDate = "11/3/2003",
                            IsDeleted = false,
                            Name = "Dorri",
                            Price = 0m
                        },
                        new
                        {
                            Id = "2fd0fec5-5955-47a8-a81f-d11cdc92d012",
                            CreatedDate = "5/13/2017",
                            IsDeleted = true,
                            Name = "Tait",
                            Price = 0m
                        },
                        new
                        {
                            Id = "2ef237f7-f1b2-4d96-aa4b-6f809177e1a5",
                            CreatedDate = "9/18/2013",
                            IsDeleted = true,
                            Name = "Melesa",
                            Price = 0m
                        },
                        new
                        {
                            Id = "9f68b61d-6e38-46a0-884c-6ed7bc189de6",
                            CreatedDate = "11/13/2003",
                            IsDeleted = true,
                            Name = "Sigrid",
                            Price = 0m
                        },
                        new
                        {
                            Id = "2c20eb70-6008-43ef-8808-a816057157f9",
                            CreatedDate = "8/25/2017",
                            IsDeleted = false,
                            Name = "Sephira",
                            Price = 0m
                        },
                        new
                        {
                            Id = "aac39f8e-95a0-4139-96af-c807c3ede9d7",
                            CreatedDate = "2/5/2009",
                            IsDeleted = true,
                            Name = "Jilli",
                            Price = 0m
                        },
                        new
                        {
                            Id = "d70f2b80-21dc-4d60-a283-f2ee9afef5bd",
                            CreatedDate = "3/5/2003",
                            IsDeleted = false,
                            Name = "Roslyn",
                            Price = 0m
                        },
                        new
                        {
                            Id = "eac60b58-5df6-4675-9cd5-dc0a24fe5153",
                            CreatedDate = "8/5/2018",
                            IsDeleted = false,
                            Name = "Emlyn",
                            Price = 0m
                        },
                        new
                        {
                            Id = "906674b1-cb9f-4a27-b564-123f9d53df9d",
                            CreatedDate = "7/25/2009",
                            IsDeleted = true,
                            Name = "Hershel",
                            Price = 0m
                        },
                        new
                        {
                            Id = "0a782c84-7975-4f6e-b0ae-dff15a66d38d",
                            CreatedDate = "9/11/2001",
                            IsDeleted = true,
                            Name = "Willa",
                            Price = 0m
                        },
                        new
                        {
                            Id = "c4c47ca8-0d15-4b85-b089-c9cde0234b81",
                            CreatedDate = "5/23/2013",
                            IsDeleted = false,
                            Name = "Brendon",
                            Price = 0m
                        },
                        new
                        {
                            Id = "57b216bc-30a0-4bc7-93d3-5a919333e0d1",
                            CreatedDate = "8/22/2019",
                            IsDeleted = false,
                            Name = "Mendel",
                            Price = 0m
                        },
                        new
                        {
                            Id = "759df1f4-7d6c-4fb8-9841-0b9f9a47c850",
                            CreatedDate = "12/5/2011",
                            IsDeleted = false,
                            Name = "Marven",
                            Price = 0m
                        },
                        new
                        {
                            Id = "4d66f81d-3fd9-4dd5-86a4-9e0c59e1a11f",
                            CreatedDate = "12/5/2014",
                            IsDeleted = false,
                            Name = "Dewie",
                            Price = 0m
                        },
                        new
                        {
                            Id = "4084c7bd-b6d7-4134-a917-4910f75a779f",
                            CreatedDate = "2/19/2003",
                            IsDeleted = false,
                            Name = "Teddi",
                            Price = 0m
                        },
                        new
                        {
                            Id = "b3b4c787-f644-4bd9-b124-df7eca9b3bf9",
                            CreatedDate = "3/7/2005",
                            IsDeleted = true,
                            Name = "Karie",
                            Price = 0m
                        },
                        new
                        {
                            Id = "5680d15a-34d7-43d1-834e-e1f25f83c0e9",
                            CreatedDate = "5/30/2005",
                            IsDeleted = false,
                            Name = "Nadeen",
                            Price = 0m
                        },
                        new
                        {
                            Id = "7e166282-811b-420c-a194-4496feb11f3d",
                            CreatedDate = "1/21/2008",
                            IsDeleted = true,
                            Name = "Aubine",
                            Price = 0m
                        },
                        new
                        {
                            Id = "0fa79e3f-bb5e-4466-aefa-c484169cbc40",
                            CreatedDate = "5/8/2013",
                            IsDeleted = false,
                            Name = "Nikola",
                            Price = 0m
                        },
                        new
                        {
                            Id = "d21eab2d-702a-4123-889b-6b2cb3d9a930",
                            CreatedDate = "2/22/2011",
                            IsDeleted = false,
                            Name = "Bibbie",
                            Price = 0m
                        },
                        new
                        {
                            Id = "9330a823-6f8d-4ed0-b620-fdf3dbadcbd8",
                            CreatedDate = "4/19/2005",
                            IsDeleted = false,
                            Name = "Ira",
                            Price = 0m
                        },
                        new
                        {
                            Id = "366442da-d2fd-4d32-955d-c473cb795454",
                            CreatedDate = "10/24/2001",
                            IsDeleted = true,
                            Name = "Orsa",
                            Price = 0m
                        },
                        new
                        {
                            Id = "cfb4f644-ff2a-495d-a258-470dd5fffee3",
                            CreatedDate = "7/18/2014",
                            IsDeleted = true,
                            Name = "Gerik",
                            Price = 0m
                        },
                        new
                        {
                            Id = "40aff1e5-2dcb-4fea-baa0-bc5db83bb74d",
                            CreatedDate = "4/1/2016",
                            IsDeleted = true,
                            Name = "Cly",
                            Price = 0m
                        },
                        new
                        {
                            Id = "26769601-30ce-472a-b73e-bf9acd522194",
                            CreatedDate = "6/28/2016",
                            IsDeleted = true,
                            Name = "Clevey",
                            Price = 0m
                        },
                        new
                        {
                            Id = "efbbf66c-d577-4222-82b3-0c50d56c207a",
                            CreatedDate = "8/22/2009",
                            IsDeleted = false,
                            Name = "Richy",
                            Price = 0m
                        },
                        new
                        {
                            Id = "c4fbc0b1-0705-486e-b908-d59b014921fb",
                            CreatedDate = "1/1/2005",
                            IsDeleted = false,
                            Name = "Chuck",
                            Price = 0m
                        },
                        new
                        {
                            Id = "502beee2-2478-47bf-bce6-fefe53eeb447",
                            CreatedDate = "2/16/2016",
                            IsDeleted = false,
                            Name = "Forrester",
                            Price = 0m
                        },
                        new
                        {
                            Id = "d630204f-183d-4700-a060-991df04c6f5b",
                            CreatedDate = "2/27/2018",
                            IsDeleted = false,
                            Name = "Gloriana",
                            Price = 0m
                        },
                        new
                        {
                            Id = "045d6244-029b-45eb-acf9-9a807b91da30",
                            CreatedDate = "1/8/2009",
                            IsDeleted = false,
                            Name = "Enrico",
                            Price = 0m
                        },
                        new
                        {
                            Id = "684a5512-c8db-4bfc-82b8-d1100ffd1e13",
                            CreatedDate = "1/30/2006",
                            IsDeleted = true,
                            Name = "Bertram",
                            Price = 0m
                        },
                        new
                        {
                            Id = "70389de8-8179-4959-a701-dc18b6cbc2d0",
                            CreatedDate = "8/20/2016",
                            IsDeleted = true,
                            Name = "Amalita",
                            Price = 0m
                        },
                        new
                        {
                            Id = "96a05055-f04d-4d87-a2c0-22fda27a97d1",
                            CreatedDate = "11/17/2013",
                            IsDeleted = false,
                            Name = "Kiel",
                            Price = 0m
                        },
                        new
                        {
                            Id = "df01593d-fb40-454a-98ce-30632da1cda6",
                            CreatedDate = "10/11/2013",
                            IsDeleted = true,
                            Name = "Amie",
                            Price = 0m
                        },
                        new
                        {
                            Id = "8bfe4dde-d21c-46fb-88c8-12b7f800eec2",
                            CreatedDate = "4/28/2013",
                            IsDeleted = false,
                            Name = "Holden",
                            Price = 0m
                        },
                        new
                        {
                            Id = "95fbbb4c-143e-4e26-a9b2-0dacaece76f5",
                            CreatedDate = "7/16/2002",
                            IsDeleted = true,
                            Name = "Loree",
                            Price = 0m
                        },
                        new
                        {
                            Id = "2e333162-e295-45b1-8fea-9364ff006c62",
                            CreatedDate = "8/3/2009",
                            IsDeleted = false,
                            Name = "Mikey",
                            Price = 0m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
