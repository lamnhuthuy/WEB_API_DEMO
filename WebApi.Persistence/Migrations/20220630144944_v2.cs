using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Persistence.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "All the must-have releases from Nike, with everything from icons like the Nike Air Force 1 and Nike Air Max line, to Nike SB, to the latest in-demand collaborations from the famous footwear brand known and loved across the globe.", "Nike" },
                    { 2, "The \"Brand with the 3 Stripes\" is a legend, birthing classics from the Stan Smith to the Superstar before reinventing itself with NMD, Ultra Boost, and its Yeezy collection.", "Adidas" },
                    { 3, "Known for premium quality and ultimate comfort, New Balance is one of the world’s premier athletic footwear brands. Find a full range of the New England-based brand’s retro runners, modern hits, and coveted collaborations here.", "New Balance" },
                    { 4, "More than a century of established excellence.", "Converse" },
                    { 5, "Live \"Off The Wall\" with Vans Old Skools, Vans Slip-Ons, and more.", "Vans" },
                    { 6, "Retro classics like the Gel-Lyte III and much more.", "Asics" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "Description", "Name", "Price", "Size" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 6, 30, 21, 49, 43, 904, DateTimeKind.Local).AddTicks(3276), "The Nike Dunk High “Dark Curry” puts an appealing lifestyle look on the timeless high-top shoe. The “Dark Curry” was released in March 2021 and exemplifies Nike’s efforts of expanding the Dunk’s footprint in sneakers. A year earlier, in 2020, the Nike Dunk re-emerged from relative obscurity to once again capture the attention of sneaker collectors due to an impressive amount of limited edition collaborations and returning retro colorways.As for the design of the “Dark Curry,” hairy orange-brown suede overlays on the model’s forefoot, eyelets, collar, and heel contrast the black brushed suede base. A darker shade of brown suede can be found on the Swoosh branding on either side and on the small pull tab on the heel. Nike layers brown laces over the black mesh tongue and adds a midsole for a timeless look. Underfoot, a tan outsole finishes off the look of the “Dark Curry.” ", "Nike Dunk High “Dark Curry” ", 2500000m, 42 },
                    { 2, 2, new DateTime(2022, 6, 30, 21, 49, 43, 904, DateTimeKind.Local).AddTicks(3287), "The BBC x Pharrell x adidas NMD Hu “Astronaut Blue” is a November 2021 collaboration between the Virginia native, his streetwear brand, and adidas on the former’s popular signature shoe. This three-way collaboration between Billionaire Boys Club, Pharrell, and adidas brings a neutral-colored look to the NMD Hu. The “Astronaut Blue” features BBC’s signature “Astronaut” branding on its design, specifically on the top of both the left and right shoe. The upper is constructed from a Halo Blue-colored sweater-like material, the same ribbed knit upper that is also found on the adidas NMD Hu’s “Cream” colorway. The shoe is constructed in a slip-on-like style with wraparound laces incorporated into the translucent midfoot cage found on either side. BBC’s “Astronaut” logo appears on the back of the left shoe while adidas’s Trefoil logo is found on the back of the right shoe. Underfoot, a responsive Boost midsole completes the look.", "Pharrell - Billionaire Boys Club - Astronaut Blue ", 2100000m, 41 },
                    { 3, 3, new DateTime(2022, 6, 30, 21, 49, 43, 904, DateTimeKind.Local).AddTicks(3289), "The Salehe Bembury x New Balance 2002R is the second highly coveted collaboration by the footwear and fashion designer and New Balance. As its nickname implies, the colorway is inspired by water, the source of life for us all, and is colored accordingly with a refreshing aqua blue hairy suede upper. Premium brown leather detailing is found on the tongue and at the ankle, while the light tan mesh base adds plenty of breathability. Shearling N logos in green add another earthy vibe. New Balance's NERGY foam midsole provides a light and cushioned feel all day long", "Salehe Bembury - Water Be The Guide", 2400000m, 42 },
                    { 4, 4, new DateTime(2022, 6, 30, 21, 49, 43, 904, DateTimeKind.Local).AddTicks(3289), "The Converse Run Star Hike Hi gives the classic Chuck Taylor design an edgy twist with its chunky platform style and jagged sole. The upper remains untouched from its original style with the black canvas construction, white rubber toe cap, and Chuck Taylor emblem. Meanwhile, the bottom introduces a new look with a two-tone outsole and thick platform that remains true to its iconic roots. This iteration lends a fashion-forward appeal and modern vibe.", "Run Star Hike", 1300000m, 42 },
                    { 5, 5, new DateTime(2022, 6, 30, 21, 49, 43, 904, DateTimeKind.Local).AddTicks(3290), "The Notre x Vans OG Old Skool LX \"White\" is one of several colorways of the classic lifestyle shoe created by the Chicago clothing and sneaker boutique and Vans for Fall 2020. The Vans OG Old Skool LX receives several updates in design from its venerable Old Skool relative, including a new premium suede construction, a padded leather collar, and cream, vulcanized midsole. Here, on the Notre-designed “White” colorway, hairy cream suede can be found on the entire upper. Notre places its signature handshake logo on either side in place of the Old Skool’s signature wavy detailing. A black “Vans” branded license plate resides on the heel of the cream sole", "Vans attitude Notre - White", 1600000m, 42 },
                    { 6, 6, new DateTime(2022, 6, 30, 21, 49, 43, 904, DateTimeKind.Local).AddTicks(3291), "The Concepts x ASICS GEL-Lyte III \"Otoro\" is a collaborative sneaker that exemplifies storytelling at its finest. Symbolic of the Bluefin Tuna and its highly acclaimed belly fat called “Otoro,” this special-edition shoe updates the Gel-Lyte III silhouette with premium pigskin suede in various shades of pink—which is a nod to the beautiful color of the fish. Reflective accents represent sushi tools used to eat the delectable dish. To commemorate the collaboration, a Concepts logo is debossed into the lateral heel area", " Asics Concepts - Otoro", 2000000m, 42 },
                    { 7, 6, new DateTime(2022, 6, 30, 21, 49, 43, 904, DateTimeKind.Local).AddTicks(3292), "These Asics Gel Excite 7 Men's Running Shoes have been crafted with an AmpliFoam midsole which delivers a flexible and tactile ride as well as offering exceptional cushioning with every stride. The breathable mesh fabric upper allows your feet to remain cool and comfortable throughout your run, whilst the GEL technology helps absorb shock and adds further cushioning for a comfortable running experience.", "Asics Gel Excite 7 Men's Running", 1900000m, 42 },
                    { 8, 4, new DateTime(2022, 6, 30, 21, 49, 43, 904, DateTimeKind.Local).AddTicks(3293), "Palladium Pampa Lite Overlab Neon for active and on-the-go young people, made from a combination of two high-quality waterproof polyester and ballistic mesh fabrics. In addition, it comes with an outsole that uses advanced Lite - Tech technology to help reduce the weight of the shoes significantly. Vibrant neon colors along with brand details give the design a striking trendy look, with a trendy look and setting it apart from the crowd.", "Palladium Pampa Lite Overlab Neon", 1700000m, 42 },
                    { 9, 1, new DateTime(2022, 6, 30, 21, 49, 43, 904, DateTimeKind.Local).AddTicks(3294), "White leather/rubber Air Force 1 '07 Craft sneakers from NIKE featuring round toe, flat rubber sole, front lace - up fastening, branded insole, signature Swoosh logo detail and perforated design.These styles are supplied by a premium sneaker marketplace.Stocking only the most sought - after footwear, they source and curate some of the most hard to find sneakers from around the world", "Nike Air Max 98 South Beach", 1750000m, 42 },
                    { 10, 3, new DateTime(2022, 6, 30, 21, 49, 43, 904, DateTimeKind.Local).AddTicks(3295), "The Joe Freshgoods x New Balance 990V3 “Outside Clothes” is the much anticipated follow up to the Chicago native’s heralded collaboration with the Boston footwear company on the 992 “No Emotions Are Emotions” from 2020. The “Outside Clothes” colorway of the classic 990V3 was released in limited quantities exclusively in Joe Freshgoods’ hometown of Chicago at Garfield Park where he grew up. Accompanied by an advertisement directed by Mike Carson and scored by Alchemist that explains the origins of the design, the multicolor look features beige suede overlays atop an aqua mesh base. A light blue “N” logo appears on both sides of the shoe. Neon green “JFG” branding is printed on the lateral side of the heel and “Outside” and “Clothes” are embroidered in green script on the left and right shoe, respectively. The phrase “Made for Us” appears on the heel. Together, the colors on the shoe: green, brown, and blue, represent grass, dirt, and the sky—all elements of being outside on a warm summer’s day", "Joe Freshgoods x New Balance 990V3 Outside Clothes", 2400000m, 42 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
