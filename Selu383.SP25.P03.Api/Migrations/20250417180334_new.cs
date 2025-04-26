using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Selu383.SP25.P03.Api.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Col", "IsTaken", "Number", "Row", "TheaterId" },
                values: new object[,]
                {
                    { 5000, 0, false, 1, "A", 5 },
                    { 5001, 1, false, 2, "A", 5 },
                    { 5002, 2, false, 3, "A", 5 },
                    { 5003, 3, false, 4, "A", 5 },
                    { 5004, 4, false, 5, "A", 5 },
                    { 5005, 5, false, 6, "A", 5 },
                    { 5006, 6, false, 7, "A", 5 },
                    { 5007, 8, false, 8, "A", 5 },
                    { 5008, 9, false, 9, "A", 5 },
                    { 5009, 10, false, 10, "A", 5 },
                    { 5010, 11, false, 11, "A", 5 },
                    { 5011, 12, false, 12, "A", 5 },
                    { 5012, 13, false, 13, "A", 5 },
                    { 5013, 14, false, 14, "A", 5 },
                    { 5014, 0, false, 1, "B", 5 },
                    { 5015, 1, false, 2, "B", 5 },
                    { 5016, 2, false, 3, "B", 5 },
                    { 5017, 3, false, 4, "B", 5 },
                    { 5018, 4, false, 5, "B", 5 },
                    { 5019, 5, false, 6, "B", 5 },
                    { 5020, 6, false, 7, "B", 5 },
                    { 5021, 8, false, 8, "B", 5 },
                    { 5022, 9, false, 9, "B", 5 },
                    { 5023, 10, false, 10, "B", 5 },
                    { 5024, 11, false, 11, "B", 5 },
                    { 5025, 12, false, 12, "B", 5 },
                    { 5026, 13, false, 13, "B", 5 },
                    { 5027, 14, false, 14, "B", 5 },
                    { 5028, 0, false, 1, "C", 5 },
                    { 5029, 1, false, 2, "C", 5 },
                    { 5030, 2, false, 3, "C", 5 },
                    { 5031, 3, false, 4, "C", 5 },
                    { 5032, 4, false, 5, "C", 5 },
                    { 5033, 5, false, 6, "C", 5 },
                    { 5034, 6, false, 7, "C", 5 },
                    { 5035, 8, false, 8, "C", 5 },
                    { 5036, 9, false, 9, "C", 5 },
                    { 5037, 10, false, 10, "C", 5 },
                    { 5038, 11, false, 11, "C", 5 },
                    { 5039, 12, false, 12, "C", 5 },
                    { 5040, 13, false, 13, "C", 5 },
                    { 5041, 14, false, 14, "C", 5 },
                    { 5042, 0, false, 1, "D", 5 },
                    { 5043, 1, false, 2, "D", 5 },
                    { 5044, 2, false, 3, "D", 5 },
                    { 5045, 3, false, 4, "D", 5 },
                    { 5046, 4, false, 5, "D", 5 },
                    { 5047, 5, false, 6, "D", 5 },
                    { 5048, 6, false, 7, "D", 5 },
                    { 5049, 8, false, 8, "D", 5 },
                    { 5050, 9, false, 9, "D", 5 },
                    { 5051, 10, false, 10, "D", 5 },
                    { 5052, 11, false, 11, "D", 5 },
                    { 5053, 12, false, 12, "D", 5 },
                    { 5054, 13, false, 13, "D", 5 },
                    { 5055, 14, false, 14, "D", 5 },
                    { 5056, 0, false, 1, "E", 5 },
                    { 5057, 1, false, 2, "E", 5 },
                    { 5058, 2, false, 3, "E", 5 },
                    { 5059, 3, false, 4, "E", 5 },
                    { 5060, 4, false, 5, "E", 5 },
                    { 5061, 5, false, 6, "E", 5 },
                    { 5062, 6, false, 7, "E", 5 },
                    { 5063, 8, false, 8, "E", 5 },
                    { 5064, 9, false, 9, "E", 5 },
                    { 5065, 10, false, 10, "E", 5 },
                    { 5066, 11, false, 11, "E", 5 },
                    { 5067, 12, false, 12, "E", 5 },
                    { 5068, 13, false, 13, "E", 5 },
                    { 5069, 14, false, 14, "E", 5 },
                    { 5070, 0, false, 1, "F", 5 },
                    { 5071, 1, false, 2, "F", 5 },
                    { 5072, 2, false, 3, "F", 5 },
                    { 5073, 3, false, 4, "F", 5 },
                    { 5074, 4, false, 5, "F", 5 },
                    { 5075, 5, false, 6, "F", 5 },
                    { 5076, 6, false, 7, "F", 5 },
                    { 5077, 8, false, 8, "F", 5 },
                    { 5078, 9, false, 9, "F", 5 },
                    { 5079, 10, false, 10, "F", 5 },
                    { 5080, 11, false, 11, "F", 5 },
                    { 5081, 12, false, 12, "F", 5 },
                    { 5082, 13, false, 13, "F", 5 },
                    { 5083, 14, false, 14, "F", 5 },
                    { 5084, 0, false, 1, "G", 5 },
                    { 5085, 1, false, 2, "G", 5 },
                    { 5086, 2, false, 3, "G", 5 },
                    { 5087, 3, false, 4, "G", 5 },
                    { 5088, 4, false, 5, "G", 5 },
                    { 5089, 5, false, 6, "G", 5 },
                    { 5090, 6, false, 7, "G", 5 },
                    { 5091, 8, false, 8, "G", 5 },
                    { 5092, 9, false, 9, "G", 5 },
                    { 5093, 10, false, 10, "G", 5 },
                    { 5094, 11, false, 11, "G", 5 },
                    { 5095, 12, false, 12, "G", 5 },
                    { 5096, 13, false, 13, "G", 5 },
                    { 5097, 14, false, 14, "G", 5 },
                    { 5098, 0, false, 1, "H", 5 },
                    { 5099, 1, false, 2, "H", 5 },
                    { 5100, 2, false, 3, "H", 5 },
                    { 5101, 3, false, 4, "H", 5 },
                    { 5102, 4, false, 5, "H", 5 },
                    { 5103, 5, false, 6, "H", 5 },
                    { 5104, 6, false, 7, "H", 5 },
                    { 5105, 8, false, 8, "H", 5 },
                    { 5106, 9, false, 9, "H", 5 },
                    { 5107, 10, false, 10, "H", 5 },
                    { 5108, 11, false, 11, "H", 5 },
                    { 5109, 12, false, 12, "H", 5 },
                    { 5110, 13, false, 13, "H", 5 },
                    { 5111, 14, false, 14, "H", 5 },
                    { 5112, 0, false, 1, "I", 5 },
                    { 5113, 1, false, 2, "I", 5 },
                    { 5114, 2, false, 3, "I", 5 },
                    { 5115, 3, false, 4, "I", 5 },
                    { 5116, 4, false, 5, "I", 5 },
                    { 5117, 5, false, 6, "I", 5 },
                    { 5118, 6, false, 7, "I", 5 },
                    { 5119, 8, false, 8, "I", 5 },
                    { 5120, 9, false, 9, "I", 5 },
                    { 5121, 10, false, 10, "I", 5 },
                    { 5122, 11, false, 11, "I", 5 },
                    { 5123, 12, false, 12, "I", 5 },
                    { 5124, 13, false, 13, "I", 5 },
                    { 5125, 14, false, 14, "I", 5 },
                    { 5126, 0, false, 1, "J", 5 },
                    { 5127, 1, false, 2, "J", 5 },
                    { 5128, 2, false, 3, "J", 5 },
                    { 5129, 3, false, 4, "J", 5 },
                    { 5130, 4, false, 5, "J", 5 },
                    { 5131, 5, false, 6, "J", 5 },
                    { 5132, 6, false, 7, "J", 5 },
                    { 5133, 8, false, 8, "J", 5 },
                    { 5134, 9, false, 9, "J", 5 },
                    { 5135, 10, false, 10, "J", 5 },
                    { 5136, 11, false, 11, "J", 5 },
                    { 5137, 12, false, 12, "J", 5 },
                    { 5138, 13, false, 13, "J", 5 },
                    { 5139, 14, false, 14, "J", 5 },
                    { 6000, 0, false, 1, "A", 6 },
                    { 6001, 1, false, 2, "A", 6 },
                    { 6002, 2, false, 3, "A", 6 },
                    { 6003, 3, false, 4, "A", 6 },
                    { 6004, 4, false, 5, "A", 6 },
                    { 6005, 5, false, 6, "A", 6 },
                    { 6006, 6, false, 7, "A", 6 },
                    { 6007, 7, false, 8, "A", 6 },
                    { 6008, 8, false, 9, "A", 6 },
                    { 6009, 9, false, 10, "A", 6 },
                    { 6010, 11, false, 11, "A", 6 },
                    { 6011, 12, false, 12, "A", 6 },
                    { 6012, 13, false, 13, "A", 6 },
                    { 6013, 14, false, 14, "A", 6 },
                    { 6014, 15, false, 15, "A", 6 },
                    { 6015, 16, false, 16, "A", 6 },
                    { 6016, 17, false, 17, "A", 6 },
                    { 6017, 18, false, 18, "A", 6 },
                    { 6018, 19, false, 19, "A", 6 },
                    { 6019, 0, false, 1, "B", 6 },
                    { 6020, 1, false, 2, "B", 6 },
                    { 6021, 2, false, 3, "B", 6 },
                    { 6022, 3, false, 4, "B", 6 },
                    { 6023, 4, false, 5, "B", 6 },
                    { 6024, 5, false, 6, "B", 6 },
                    { 6025, 6, false, 7, "B", 6 },
                    { 6026, 7, false, 8, "B", 6 },
                    { 6027, 8, false, 9, "B", 6 },
                    { 6028, 9, false, 10, "B", 6 },
                    { 6029, 11, false, 11, "B", 6 },
                    { 6030, 12, false, 12, "B", 6 },
                    { 6031, 13, false, 13, "B", 6 },
                    { 6032, 14, false, 14, "B", 6 },
                    { 6033, 15, false, 15, "B", 6 },
                    { 6034, 16, false, 16, "B", 6 },
                    { 6035, 17, false, 17, "B", 6 },
                    { 6036, 18, false, 18, "B", 6 },
                    { 6037, 19, false, 19, "B", 6 },
                    { 6038, 0, false, 1, "C", 6 },
                    { 6039, 1, false, 2, "C", 6 },
                    { 6040, 2, false, 3, "C", 6 },
                    { 6041, 3, false, 4, "C", 6 },
                    { 6042, 4, false, 5, "C", 6 },
                    { 6043, 5, false, 6, "C", 6 },
                    { 6044, 6, false, 7, "C", 6 },
                    { 6045, 7, false, 8, "C", 6 },
                    { 6046, 8, false, 9, "C", 6 },
                    { 6047, 9, false, 10, "C", 6 },
                    { 6048, 11, false, 11, "C", 6 },
                    { 6049, 12, false, 12, "C", 6 },
                    { 6050, 13, false, 13, "C", 6 },
                    { 6051, 14, false, 14, "C", 6 },
                    { 6052, 15, false, 15, "C", 6 },
                    { 6053, 16, false, 16, "C", 6 },
                    { 6054, 17, false, 17, "C", 6 },
                    { 6055, 18, false, 18, "C", 6 },
                    { 6056, 19, false, 19, "C", 6 },
                    { 6057, 0, false, 1, "D", 6 },
                    { 6058, 1, false, 2, "D", 6 },
                    { 6059, 2, false, 3, "D", 6 },
                    { 6060, 3, false, 4, "D", 6 },
                    { 6061, 4, false, 5, "D", 6 },
                    { 6062, 5, false, 6, "D", 6 },
                    { 6063, 6, false, 7, "D", 6 },
                    { 6064, 7, false, 8, "D", 6 },
                    { 6065, 8, false, 9, "D", 6 },
                    { 6066, 9, false, 10, "D", 6 },
                    { 6067, 11, false, 11, "D", 6 },
                    { 6068, 12, false, 12, "D", 6 },
                    { 6069, 13, false, 13, "D", 6 },
                    { 6070, 14, false, 14, "D", 6 },
                    { 6071, 15, false, 15, "D", 6 },
                    { 6072, 16, false, 16, "D", 6 },
                    { 6073, 17, false, 17, "D", 6 },
                    { 6074, 18, false, 18, "D", 6 },
                    { 6075, 19, false, 19, "D", 6 },
                    { 6076, 0, false, 1, "E", 6 },
                    { 6077, 1, false, 2, "E", 6 },
                    { 6078, 2, false, 3, "E", 6 },
                    { 6079, 3, false, 4, "E", 6 },
                    { 6080, 4, false, 5, "E", 6 },
                    { 6081, 5, false, 6, "E", 6 },
                    { 6082, 6, false, 7, "E", 6 },
                    { 6083, 7, false, 8, "E", 6 },
                    { 6084, 8, false, 9, "E", 6 },
                    { 6085, 9, false, 10, "E", 6 },
                    { 6086, 11, false, 11, "E", 6 },
                    { 6087, 12, false, 12, "E", 6 },
                    { 6088, 13, false, 13, "E", 6 },
                    { 6089, 14, false, 14, "E", 6 },
                    { 6090, 15, false, 15, "E", 6 },
                    { 6091, 16, false, 16, "E", 6 },
                    { 6092, 17, false, 17, "E", 6 },
                    { 6093, 18, false, 18, "E", 6 },
                    { 6094, 19, false, 19, "E", 6 },
                    { 6095, 0, false, 1, "F", 6 },
                    { 6096, 1, false, 2, "F", 6 },
                    { 6097, 2, false, 3, "F", 6 },
                    { 6098, 3, false, 4, "F", 6 },
                    { 6099, 4, false, 5, "F", 6 },
                    { 6100, 5, false, 6, "F", 6 },
                    { 6101, 6, false, 7, "F", 6 },
                    { 6102, 7, false, 8, "F", 6 },
                    { 6103, 8, false, 9, "F", 6 },
                    { 6104, 9, false, 10, "F", 6 },
                    { 6105, 11, false, 11, "F", 6 },
                    { 6106, 12, false, 12, "F", 6 },
                    { 6107, 13, false, 13, "F", 6 },
                    { 6108, 14, false, 14, "F", 6 },
                    { 6109, 15, false, 15, "F", 6 },
                    { 6110, 16, false, 16, "F", 6 },
                    { 6111, 17, false, 17, "F", 6 },
                    { 6112, 18, false, 18, "F", 6 },
                    { 6113, 19, false, 19, "F", 6 },
                    { 6114, 0, false, 1, "G", 6 },
                    { 6115, 1, false, 2, "G", 6 },
                    { 6116, 2, false, 3, "G", 6 },
                    { 6117, 3, false, 4, "G", 6 },
                    { 6118, 4, false, 5, "G", 6 },
                    { 6119, 5, false, 6, "G", 6 },
                    { 6120, 6, false, 7, "G", 6 },
                    { 6121, 7, false, 8, "G", 6 },
                    { 6122, 8, false, 9, "G", 6 },
                    { 6123, 9, false, 10, "G", 6 },
                    { 6124, 11, false, 11, "G", 6 },
                    { 6125, 12, false, 12, "G", 6 },
                    { 6126, 13, false, 13, "G", 6 },
                    { 6127, 14, false, 14, "G", 6 },
                    { 6128, 15, false, 15, "G", 6 },
                    { 6129, 16, false, 16, "G", 6 },
                    { 6130, 17, false, 17, "G", 6 },
                    { 6131, 18, false, 18, "G", 6 },
                    { 6132, 19, false, 19, "G", 6 },
                    { 6133, 0, false, 1, "H", 6 },
                    { 6134, 1, false, 2, "H", 6 },
                    { 6135, 2, false, 3, "H", 6 },
                    { 6136, 3, false, 4, "H", 6 },
                    { 6137, 4, false, 5, "H", 6 },
                    { 6138, 5, false, 6, "H", 6 },
                    { 6139, 6, false, 7, "H", 6 },
                    { 6140, 7, false, 8, "H", 6 },
                    { 6141, 8, false, 9, "H", 6 },
                    { 6142, 9, false, 10, "H", 6 },
                    { 6143, 11, false, 11, "H", 6 },
                    { 6144, 12, false, 12, "H", 6 },
                    { 6145, 13, false, 13, "H", 6 },
                    { 6146, 14, false, 14, "H", 6 },
                    { 6147, 15, false, 15, "H", 6 },
                    { 6148, 16, false, 16, "H", 6 },
                    { 6149, 17, false, 17, "H", 6 },
                    { 6150, 18, false, 18, "H", 6 },
                    { 6151, 19, false, 19, "H", 6 },
                    { 6152, 0, false, 1, "I", 6 },
                    { 6153, 1, false, 2, "I", 6 },
                    { 6154, 2, false, 3, "I", 6 },
                    { 6155, 3, false, 4, "I", 6 },
                    { 6156, 4, false, 5, "I", 6 },
                    { 6157, 5, false, 6, "I", 6 },
                    { 6158, 6, false, 7, "I", 6 },
                    { 6159, 7, false, 8, "I", 6 },
                    { 6160, 8, false, 9, "I", 6 },
                    { 6161, 9, false, 10, "I", 6 },
                    { 6162, 11, false, 11, "I", 6 },
                    { 6163, 12, false, 12, "I", 6 },
                    { 6164, 13, false, 13, "I", 6 },
                    { 6165, 14, false, 14, "I", 6 },
                    { 6166, 15, false, 15, "I", 6 },
                    { 6167, 16, false, 16, "I", 6 },
                    { 6168, 17, false, 17, "I", 6 },
                    { 6169, 18, false, 18, "I", 6 },
                    { 6170, 19, false, 19, "I", 6 },
                    { 6171, 0, false, 1, "J", 6 },
                    { 6172, 1, false, 2, "J", 6 },
                    { 6173, 2, false, 3, "J", 6 },
                    { 6174, 3, false, 4, "J", 6 },
                    { 6175, 4, false, 5, "J", 6 },
                    { 6176, 5, false, 6, "J", 6 },
                    { 6177, 6, false, 7, "J", 6 },
                    { 6178, 7, false, 8, "J", 6 },
                    { 6179, 8, false, 9, "J", 6 },
                    { 6180, 9, false, 10, "J", 6 },
                    { 6181, 11, false, 11, "J", 6 },
                    { 6182, 12, false, 12, "J", 6 },
                    { 6183, 13, false, 13, "J", 6 },
                    { 6184, 14, false, 14, "J", 6 },
                    { 6185, 15, false, 15, "J", 6 },
                    { 6186, 16, false, 16, "J", 6 },
                    { 6187, 17, false, 17, "J", 6 },
                    { 6188, 18, false, 18, "J", 6 },
                    { 6189, 19, false, 19, "J", 6 },
                    { 7000, 0, false, 1, "A", 7 },
                    { 7001, 1, false, 2, "A", 7 },
                    { 7002, 2, false, 3, "A", 7 },
                    { 7003, 3, false, 4, "A", 7 },
                    { 7004, 4, false, 5, "A", 7 },
                    { 7005, 5, false, 6, "A", 7 },
                    { 7006, 6, false, 7, "A", 7 },
                    { 7007, 7, false, 8, "A", 7 },
                    { 7008, 8, false, 9, "A", 7 },
                    { 7009, 9, false, 10, "A", 7 },
                    { 7010, 10, false, 11, "A", 7 },
                    { 7011, 11, false, 12, "A", 7 },
                    { 7012, 12, false, 13, "A", 7 },
                    { 7013, 13, false, 14, "A", 7 },
                    { 7014, 14, false, 15, "A", 7 },
                    { 7015, 16, false, 16, "A", 7 },
                    { 7016, 17, false, 17, "A", 7 },
                    { 7017, 18, false, 18, "A", 7 },
                    { 7018, 19, false, 19, "A", 7 },
                    { 7019, 20, false, 20, "A", 7 },
                    { 7020, 21, false, 21, "A", 7 },
                    { 7021, 22, false, 22, "A", 7 },
                    { 7022, 23, false, 23, "A", 7 },
                    { 7023, 24, false, 24, "A", 7 },
                    { 7024, 25, false, 25, "A", 7 },
                    { 7025, 26, false, 26, "A", 7 },
                    { 7026, 27, false, 27, "A", 7 },
                    { 7027, 28, false, 28, "A", 7 },
                    { 7028, 29, false, 29, "A", 7 },
                    { 7029, 0, false, 1, "B", 7 },
                    { 7030, 1, false, 2, "B", 7 },
                    { 7031, 2, false, 3, "B", 7 },
                    { 7032, 3, false, 4, "B", 7 },
                    { 7033, 4, false, 5, "B", 7 },
                    { 7034, 5, false, 6, "B", 7 },
                    { 7035, 6, false, 7, "B", 7 },
                    { 7036, 7, false, 8, "B", 7 },
                    { 7037, 8, false, 9, "B", 7 },
                    { 7038, 9, false, 10, "B", 7 },
                    { 7039, 10, false, 11, "B", 7 },
                    { 7040, 11, false, 12, "B", 7 },
                    { 7041, 12, false, 13, "B", 7 },
                    { 7042, 13, false, 14, "B", 7 },
                    { 7043, 14, false, 15, "B", 7 },
                    { 7044, 16, false, 16, "B", 7 },
                    { 7045, 17, false, 17, "B", 7 },
                    { 7046, 18, false, 18, "B", 7 },
                    { 7047, 19, false, 19, "B", 7 },
                    { 7048, 20, false, 20, "B", 7 },
                    { 7049, 21, false, 21, "B", 7 },
                    { 7050, 22, false, 22, "B", 7 },
                    { 7051, 23, false, 23, "B", 7 },
                    { 7052, 24, false, 24, "B", 7 },
                    { 7053, 25, false, 25, "B", 7 },
                    { 7054, 26, false, 26, "B", 7 },
                    { 7055, 27, false, 27, "B", 7 },
                    { 7056, 28, false, 28, "B", 7 },
                    { 7057, 29, false, 29, "B", 7 },
                    { 7058, 0, false, 1, "C", 7 },
                    { 7059, 1, false, 2, "C", 7 },
                    { 7060, 2, false, 3, "C", 7 },
                    { 7061, 3, false, 4, "C", 7 },
                    { 7062, 4, false, 5, "C", 7 },
                    { 7063, 5, false, 6, "C", 7 },
                    { 7064, 6, false, 7, "C", 7 },
                    { 7065, 7, false, 8, "C", 7 },
                    { 7066, 8, false, 9, "C", 7 },
                    { 7067, 9, false, 10, "C", 7 },
                    { 7068, 10, false, 11, "C", 7 },
                    { 7069, 11, false, 12, "C", 7 },
                    { 7070, 12, false, 13, "C", 7 },
                    { 7071, 13, false, 14, "C", 7 },
                    { 7072, 14, false, 15, "C", 7 },
                    { 7073, 16, false, 16, "C", 7 },
                    { 7074, 17, false, 17, "C", 7 },
                    { 7075, 18, false, 18, "C", 7 },
                    { 7076, 19, false, 19, "C", 7 },
                    { 7077, 20, false, 20, "C", 7 },
                    { 7078, 21, false, 21, "C", 7 },
                    { 7079, 22, false, 22, "C", 7 },
                    { 7080, 23, false, 23, "C", 7 },
                    { 7081, 24, false, 24, "C", 7 },
                    { 7082, 25, false, 25, "C", 7 },
                    { 7083, 26, false, 26, "C", 7 },
                    { 7084, 27, false, 27, "C", 7 },
                    { 7085, 28, false, 28, "C", 7 },
                    { 7086, 29, false, 29, "C", 7 },
                    { 7087, 0, false, 1, "D", 7 },
                    { 7088, 1, false, 2, "D", 7 },
                    { 7089, 2, false, 3, "D", 7 },
                    { 7090, 3, false, 4, "D", 7 },
                    { 7091, 4, false, 5, "D", 7 },
                    { 7092, 5, false, 6, "D", 7 },
                    { 7093, 6, false, 7, "D", 7 },
                    { 7094, 7, false, 8, "D", 7 },
                    { 7095, 8, false, 9, "D", 7 },
                    { 7096, 9, false, 10, "D", 7 },
                    { 7097, 10, false, 11, "D", 7 },
                    { 7098, 11, false, 12, "D", 7 },
                    { 7099, 12, false, 13, "D", 7 },
                    { 7100, 13, false, 14, "D", 7 },
                    { 7101, 14, false, 15, "D", 7 },
                    { 7102, 16, false, 16, "D", 7 },
                    { 7103, 17, false, 17, "D", 7 },
                    { 7104, 18, false, 18, "D", 7 },
                    { 7105, 19, false, 19, "D", 7 },
                    { 7106, 20, false, 20, "D", 7 },
                    { 7107, 21, false, 21, "D", 7 },
                    { 7108, 22, false, 22, "D", 7 },
                    { 7109, 23, false, 23, "D", 7 },
                    { 7110, 24, false, 24, "D", 7 },
                    { 7111, 25, false, 25, "D", 7 },
                    { 7112, 26, false, 26, "D", 7 },
                    { 7113, 27, false, 27, "D", 7 },
                    { 7114, 28, false, 28, "D", 7 },
                    { 7115, 29, false, 29, "D", 7 },
                    { 7116, 0, false, 1, "E", 7 },
                    { 7117, 1, false, 2, "E", 7 },
                    { 7118, 2, false, 3, "E", 7 },
                    { 7119, 3, false, 4, "E", 7 },
                    { 7120, 4, false, 5, "E", 7 },
                    { 7121, 5, false, 6, "E", 7 },
                    { 7122, 6, false, 7, "E", 7 },
                    { 7123, 7, false, 8, "E", 7 },
                    { 7124, 8, false, 9, "E", 7 },
                    { 7125, 9, false, 10, "E", 7 },
                    { 7126, 10, false, 11, "E", 7 },
                    { 7127, 11, false, 12, "E", 7 },
                    { 7128, 12, false, 13, "E", 7 },
                    { 7129, 13, false, 14, "E", 7 },
                    { 7130, 14, false, 15, "E", 7 },
                    { 7131, 16, false, 16, "E", 7 },
                    { 7132, 17, false, 17, "E", 7 },
                    { 7133, 18, false, 18, "E", 7 },
                    { 7134, 19, false, 19, "E", 7 },
                    { 7135, 20, false, 20, "E", 7 },
                    { 7136, 21, false, 21, "E", 7 },
                    { 7137, 22, false, 22, "E", 7 },
                    { 7138, 23, false, 23, "E", 7 },
                    { 7139, 24, false, 24, "E", 7 },
                    { 7140, 25, false, 25, "E", 7 },
                    { 7141, 26, false, 26, "E", 7 },
                    { 7142, 27, false, 27, "E", 7 },
                    { 7143, 28, false, 28, "E", 7 },
                    { 7144, 29, false, 29, "E", 7 },
                    { 7145, 0, false, 1, "F", 7 },
                    { 7146, 1, false, 2, "F", 7 },
                    { 7147, 2, false, 3, "F", 7 },
                    { 7148, 3, false, 4, "F", 7 },
                    { 7149, 4, false, 5, "F", 7 },
                    { 7150, 5, false, 6, "F", 7 },
                    { 7151, 6, false, 7, "F", 7 },
                    { 7152, 7, false, 8, "F", 7 },
                    { 7153, 8, false, 9, "F", 7 },
                    { 7154, 9, false, 10, "F", 7 },
                    { 7155, 10, false, 11, "F", 7 },
                    { 7156, 11, false, 12, "F", 7 },
                    { 7157, 12, false, 13, "F", 7 },
                    { 7158, 13, false, 14, "F", 7 },
                    { 7159, 14, false, 15, "F", 7 },
                    { 7160, 16, false, 16, "F", 7 },
                    { 7161, 17, false, 17, "F", 7 },
                    { 7162, 18, false, 18, "F", 7 },
                    { 7163, 19, false, 19, "F", 7 },
                    { 7164, 20, false, 20, "F", 7 },
                    { 7165, 21, false, 21, "F", 7 },
                    { 7166, 22, false, 22, "F", 7 },
                    { 7167, 23, false, 23, "F", 7 },
                    { 7168, 24, false, 24, "F", 7 },
                    { 7169, 25, false, 25, "F", 7 },
                    { 7170, 26, false, 26, "F", 7 },
                    { 7171, 27, false, 27, "F", 7 },
                    { 7172, 28, false, 28, "F", 7 },
                    { 7173, 29, false, 29, "F", 7 },
                    { 7174, 0, false, 1, "G", 7 },
                    { 7175, 1, false, 2, "G", 7 },
                    { 7176, 2, false, 3, "G", 7 },
                    { 7177, 3, false, 4, "G", 7 },
                    { 7178, 4, false, 5, "G", 7 },
                    { 7179, 5, false, 6, "G", 7 },
                    { 7180, 6, false, 7, "G", 7 },
                    { 7181, 7, false, 8, "G", 7 },
                    { 7182, 8, false, 9, "G", 7 },
                    { 7183, 9, false, 10, "G", 7 },
                    { 7184, 10, false, 11, "G", 7 },
                    { 7185, 11, false, 12, "G", 7 },
                    { 7186, 12, false, 13, "G", 7 },
                    { 7187, 13, false, 14, "G", 7 },
                    { 7188, 14, false, 15, "G", 7 },
                    { 7189, 16, false, 16, "G", 7 },
                    { 7190, 17, false, 17, "G", 7 },
                    { 7191, 18, false, 18, "G", 7 },
                    { 7192, 19, false, 19, "G", 7 },
                    { 7193, 20, false, 20, "G", 7 },
                    { 7194, 21, false, 21, "G", 7 },
                    { 7195, 22, false, 22, "G", 7 },
                    { 7196, 23, false, 23, "G", 7 },
                    { 7197, 24, false, 24, "G", 7 },
                    { 7198, 25, false, 25, "G", 7 },
                    { 7199, 26, false, 26, "G", 7 },
                    { 7200, 27, false, 27, "G", 7 },
                    { 7201, 28, false, 28, "G", 7 },
                    { 7202, 29, false, 29, "G", 7 },
                    { 7203, 0, false, 1, "H", 7 },
                    { 7204, 1, false, 2, "H", 7 },
                    { 7205, 2, false, 3, "H", 7 },
                    { 7206, 3, false, 4, "H", 7 },
                    { 7207, 4, false, 5, "H", 7 },
                    { 7208, 5, false, 6, "H", 7 },
                    { 7209, 6, false, 7, "H", 7 },
                    { 7210, 7, false, 8, "H", 7 },
                    { 7211, 8, false, 9, "H", 7 },
                    { 7212, 9, false, 10, "H", 7 },
                    { 7213, 10, false, 11, "H", 7 },
                    { 7214, 11, false, 12, "H", 7 },
                    { 7215, 12, false, 13, "H", 7 },
                    { 7216, 13, false, 14, "H", 7 },
                    { 7217, 14, false, 15, "H", 7 },
                    { 7218, 16, false, 16, "H", 7 },
                    { 7219, 17, false, 17, "H", 7 },
                    { 7220, 18, false, 18, "H", 7 },
                    { 7221, 19, false, 19, "H", 7 },
                    { 7222, 20, false, 20, "H", 7 },
                    { 7223, 21, false, 21, "H", 7 },
                    { 7224, 22, false, 22, "H", 7 },
                    { 7225, 23, false, 23, "H", 7 },
                    { 7226, 24, false, 24, "H", 7 },
                    { 7227, 25, false, 25, "H", 7 },
                    { 7228, 26, false, 26, "H", 7 },
                    { 7229, 27, false, 27, "H", 7 },
                    { 7230, 28, false, 28, "H", 7 },
                    { 7231, 29, false, 29, "H", 7 },
                    { 7232, 0, false, 1, "I", 7 },
                    { 7233, 1, false, 2, "I", 7 },
                    { 7234, 2, false, 3, "I", 7 },
                    { 7235, 3, false, 4, "I", 7 },
                    { 7236, 4, false, 5, "I", 7 },
                    { 7237, 5, false, 6, "I", 7 },
                    { 7238, 6, false, 7, "I", 7 },
                    { 7239, 7, false, 8, "I", 7 },
                    { 7240, 8, false, 9, "I", 7 },
                    { 7241, 9, false, 10, "I", 7 },
                    { 7242, 10, false, 11, "I", 7 },
                    { 7243, 11, false, 12, "I", 7 },
                    { 7244, 12, false, 13, "I", 7 },
                    { 7245, 13, false, 14, "I", 7 },
                    { 7246, 14, false, 15, "I", 7 },
                    { 7247, 16, false, 16, "I", 7 },
                    { 7248, 17, false, 17, "I", 7 },
                    { 7249, 18, false, 18, "I", 7 },
                    { 7250, 19, false, 19, "I", 7 },
                    { 7251, 20, false, 20, "I", 7 },
                    { 7252, 21, false, 21, "I", 7 },
                    { 7253, 22, false, 22, "I", 7 },
                    { 7254, 23, false, 23, "I", 7 },
                    { 7255, 24, false, 24, "I", 7 },
                    { 7256, 25, false, 25, "I", 7 },
                    { 7257, 26, false, 26, "I", 7 },
                    { 7258, 27, false, 27, "I", 7 },
                    { 7259, 28, false, 28, "I", 7 },
                    { 7260, 29, false, 29, "I", 7 },
                    { 7261, 0, false, 1, "J", 7 },
                    { 7262, 1, false, 2, "J", 7 },
                    { 7263, 2, false, 3, "J", 7 },
                    { 7264, 3, false, 4, "J", 7 },
                    { 7265, 4, false, 5, "J", 7 },
                    { 7266, 5, false, 6, "J", 7 },
                    { 7267, 6, false, 7, "J", 7 },
                    { 7268, 7, false, 8, "J", 7 },
                    { 7269, 8, false, 9, "J", 7 },
                    { 7270, 9, false, 10, "J", 7 },
                    { 7271, 10, false, 11, "J", 7 },
                    { 7272, 11, false, 12, "J", 7 },
                    { 7273, 12, false, 13, "J", 7 },
                    { 7274, 13, false, 14, "J", 7 },
                    { 7275, 14, false, 15, "J", 7 },
                    { 7276, 16, false, 16, "J", 7 },
                    { 7277, 17, false, 17, "J", 7 },
                    { 7278, 18, false, 18, "J", 7 },
                    { 7279, 19, false, 19, "J", 7 },
                    { 7280, 20, false, 20, "J", 7 },
                    { 7281, 21, false, 21, "J", 7 },
                    { 7282, 22, false, 22, "J", 7 },
                    { 7283, 23, false, 23, "J", 7 },
                    { 7284, 24, false, 24, "J", 7 },
                    { 7285, 25, false, 25, "J", 7 },
                    { 7286, 26, false, 26, "J", 7 },
                    { 7287, 27, false, 27, "J", 7 },
                    { 7288, 28, false, 28, "J", 7 },
                    { 7289, 29, false, 29, "J", 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5000);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5001);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5002);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5003);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5004);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5005);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5006);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5007);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5008);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5009);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5010);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5011);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5012);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5013);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5014);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5015);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5016);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5017);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5018);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5019);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5020);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5021);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5022);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5023);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5024);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5025);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5026);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5027);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5028);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5029);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5030);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5031);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5032);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5033);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5034);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5035);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5036);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5037);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5038);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5039);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5040);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5041);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5042);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5043);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5044);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5045);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5046);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5047);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5048);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5049);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5050);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5051);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5052);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5053);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5054);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5055);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5056);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5057);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5058);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5059);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5060);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5061);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5062);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5063);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5064);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5065);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5066);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5067);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5068);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5069);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5070);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5071);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5072);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5073);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5074);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5075);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5076);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5077);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5078);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5079);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5080);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5081);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5082);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5083);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5084);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5085);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5086);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5087);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5088);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5089);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5090);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5091);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5092);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5093);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5094);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5095);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5096);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5097);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5098);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5099);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5100);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5101);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5102);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5103);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5104);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5105);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5106);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5107);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5108);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5109);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5110);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5111);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5112);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5113);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5114);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5115);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5116);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5117);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5118);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5119);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5120);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5121);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5122);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5123);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5124);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5125);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5126);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5127);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5128);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5129);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5130);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5131);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5132);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5133);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5134);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5135);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5136);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5137);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5138);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5139);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6000);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6001);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6002);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6003);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6004);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6005);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6006);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6007);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6008);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6009);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6010);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6011);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6012);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6013);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6014);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6015);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6016);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6017);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6018);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6019);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6020);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6021);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6022);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6023);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6024);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6025);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6026);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6027);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6028);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6029);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6030);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6031);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6032);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6033);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6034);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6035);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6036);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6037);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6038);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6039);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6040);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6041);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6042);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6043);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6044);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6045);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6046);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6047);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6048);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6049);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6050);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6051);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6052);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6053);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6054);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6055);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6056);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6057);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6058);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6059);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6060);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6061);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6062);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6063);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6064);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6065);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6066);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6067);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6068);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6069);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6070);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6071);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6072);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6073);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6074);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6075);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6076);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6077);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6078);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6079);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6080);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6081);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6082);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6083);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6084);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6085);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6086);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6087);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6088);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6089);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6090);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6091);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6092);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6093);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6094);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6095);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6096);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6097);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6098);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6099);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6100);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6101);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6102);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6103);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6104);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6105);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6106);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6107);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6108);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6109);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6110);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6111);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6112);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6113);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6114);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6115);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6116);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6117);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6118);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6119);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6120);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6121);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6122);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6123);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6124);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6125);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6126);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6127);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6128);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6129);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6130);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6131);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6132);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6133);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6134);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6135);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6136);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6137);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6138);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6139);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6140);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6141);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6142);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6143);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6144);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6145);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6146);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6147);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6148);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6149);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6150);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6151);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6152);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6153);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6154);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6155);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6156);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6157);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6158);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6159);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6160);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6161);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6162);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6163);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6164);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6165);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6166);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6167);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6168);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6169);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6170);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6171);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6172);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6173);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6174);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6175);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6176);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6177);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6178);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6179);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6180);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6181);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6182);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6183);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6184);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6185);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6186);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6187);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6188);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6189);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7000);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7001);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7002);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7003);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7004);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7005);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7006);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7007);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7008);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7009);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7010);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7011);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7012);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7013);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7014);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7015);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7016);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7017);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7018);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7019);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7020);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7021);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7022);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7023);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7024);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7025);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7026);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7027);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7028);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7029);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7030);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7031);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7032);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7033);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7034);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7035);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7036);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7037);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7038);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7039);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7040);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7041);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7042);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7043);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7044);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7045);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7046);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7047);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7048);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7049);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7050);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7051);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7052);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7053);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7054);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7055);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7056);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7057);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7058);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7059);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7060);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7061);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7062);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7063);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7064);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7065);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7066);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7067);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7068);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7069);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7070);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7071);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7072);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7073);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7074);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7075);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7076);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7077);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7078);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7079);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7080);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7081);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7082);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7083);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7084);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7085);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7086);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7087);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7088);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7089);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7090);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7091);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7092);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7093);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7094);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7095);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7096);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7097);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7098);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7099);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7100);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7101);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7102);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7103);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7104);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7105);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7106);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7107);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7108);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7109);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7110);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7111);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7112);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7113);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7114);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7115);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7116);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7117);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7118);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7119);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7120);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7121);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7122);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7123);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7124);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7125);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7126);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7127);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7128);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7129);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7130);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7131);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7132);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7133);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7134);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7135);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7136);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7137);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7138);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7139);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7140);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7141);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7142);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7143);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7144);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7145);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7146);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7147);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7148);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7149);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7150);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7151);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7152);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7153);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7154);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7155);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7156);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7157);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7158);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7159);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7160);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7161);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7162);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7163);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7164);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7165);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7166);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7167);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7168);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7169);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7170);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7171);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7172);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7173);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7174);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7175);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7176);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7177);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7178);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7179);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7180);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7181);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7182);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7183);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7184);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7185);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7186);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7187);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7188);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7189);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7190);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7191);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7192);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7193);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7194);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7195);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7196);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7197);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7198);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7199);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7200);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7201);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7202);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7203);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7204);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7205);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7206);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7207);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7208);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7209);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7210);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7211);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7212);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7213);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7214);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7215);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7216);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7217);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7218);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7219);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7220);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7221);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7222);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7223);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7224);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7225);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7226);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7227);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7228);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7229);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7230);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7231);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7232);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7233);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7234);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7235);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7236);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7237);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7238);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7239);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7240);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7241);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7242);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7243);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7244);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7245);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7246);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7247);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7248);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7249);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7250);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7251);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7252);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7253);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7254);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7255);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7256);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7257);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7258);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7259);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7260);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7261);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7262);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7263);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7264);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7265);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7266);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7267);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7268);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7269);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7270);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7271);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7272);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7273);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7274);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7275);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7276);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7277);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7278);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7279);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7280);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7281);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7282);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7283);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7284);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7285);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7286);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7287);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7288);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7289);
        }
    }
}
