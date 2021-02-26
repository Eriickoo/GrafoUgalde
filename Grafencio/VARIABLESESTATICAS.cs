using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafencio
{
    public class VARIABLESESTATICAS
    {
        internal static Grafiurri grafoAntiHorario = AntiHour();
        internal static Grafiurri grafoHorario = Hour();
        public static int[,] MatrizDeAdyascencia = tablaAdyascencia();
        

        protected static int[,] tablaAdyascencia()
        {
            int[,] x = new int[,]
            {
                //Adyascencias para 1
            { 0, 908, 117, 687, 1651, 117, 1882, 1310, 889, 760, 2348, 782, 697, 1370, 1431, 395, 697, 1328, 490, 481, 1244, 810, 881, 1145, 513, 461, 1407, 1000},
                //ADYASCENCIAS PARA 2
            { 117,0, 515, 448, 970, 791, 1013, 441, 246, 181, 1707, 127, 546, 928, 750, 513, 316, 600, 540, 636, 511, 171, 572, 460, 631, 497, 538, 131},
                //ADYASCENCIAS PARA 3
            { 687, 448,0, 886, 1373, 999, 117, 844, 684, 559, 1811, 541, 984, 317, 1153, 721, 739, 291, 626, 813, 300, 344, 235, 898, 780, 704, 642, 534},
                // ADYASCENCIAS PARA 4
            { 1651, 970, 1373, 0, 922, 804, 1404, 832, 202, 479, 1619, 426, 98, 1319, 702, 744, 504, 991, 817, 867, 902, 542, 943, 416, 862, 678, 929, 522},
                // ADYASCENCIAS PARA 5
            { 117, 791, 999, 804,0, 1540, 1191, 529, 720, 997, 697, 943, 952, 1463, 220, 1262, 1022, 1148, 1335, 1385, 1046, 1029, 1430, 506, 1380, 1195, 784, 839},
                // ADYASCENCIAS PARA 6
            { 1882, 1013, 116, 1404, 1191,0, 1765, 1193, 840, 643, 2237, 665, 814, 1253, 1320, 278, 580, 1211, 373, 364, 1127, 693, 764, 1034, 396, 344, 1290, 833},
                // ADYASCENCIAS PARA 7
            { 1310, 441, 844, 832, 529, 1193, 0,662, 1202, 1194, 694, 1140, 1502, 1154, 971, 1407, 1329, 826, 1553, 1610, 737, 1072, 1352, 1257, 1605, 1432, 475, 882},
                // ADYASCENCIAS PARA 8
            { 1310, 441, 844, 832, 529, 1193, 662, 0 , 630, 622, 1223, 568, 930, 934, 309, 915, 757, 606, 981, 1038, 517, 500, 901, 595, 1033, 938, 255, 310},
                // ADYASCENCIAS PARA 9
            { 889, 246, 684, 202, 720, 840, 1202, 630, 0, 277, 1417, 223, 300, 1117, 500, 542, 302, 789, 615, 665, 700, 340, 741, 214, 660, 476, 727, 320},
                //ADYASCENCIAS PARA 10
            { 760, 181, 559, 479, 997, 643, 1194, 622, 277, 0, 1694, 54, 577, 774, 777, 365, 180, 729, 392, 480, 664, 215, 616, 491, 483, 349, 719, 312},
                //ADYASCENCIAS PARA 11
            { 2348, 1707, 1811, 1619, 697, 2237, 694, 1223, 1417, 1694, 0, 1640, 1649, 1848, 917, 1959, 1719, 1520, 2032, 2082, 1431, 1766, 2046, 1203, 2077, 1893, 1169, 1576},
                //ADYASCENCIAS PARA 12
            { 782, 127, 541, 426, 943, 665, 1140, 568, 223, 54, 1640, 0, 523, 756, 723, 387, 202, 711, 414, 510, 646, 197, 598, 437, 505, 371, 665, 258},
                //ADYASCENCIAS PARA 13
         { 697, 546, 984, 98, 952, 814, 1502, 930, 300, 577, 1649, 523, 0, 1417, 732, 842, 602, 1089, 915, 965, 1000, 640, 1041, 446, 960, 776, 1027, 620},
                //ADYASCENCIAS PARA 14
            { 1370, 928, 317, 1319, 1463, 1253, 1154, 934, 1117, 774, 1848, 756, 1417, 0, 1250, 975, 954, 328, 890, 1077, 417, 559, 499, 1331, 1044, 1041, 679, 797 },
                //ADYASCENCIAS PARA 15
            { 1431, 750, 1153, 702, 220, 1320, 971, 309, 500, 777, 917, 723, 732, 1250, 0, 1042, 802, 928, 1115, 1165, 826, 809, 1210, 286, 1160, 976, 564, 619 },
                //ADYASCENCIAS PARA 16
            { 395, 513, 721, 744, 1262, 278, 1407, 915, 542, 365, 1959, 387, 842, 975, 1042, 0, 302, 933, 95, 123, 849, 416, 486, 756, 118, 66, 1012, 605 },
                    //ADYASCENCIA PARA 17
             { 697, 316, 739, 504, 1022, 580, 1329, 757, 302, 180, 1719, 202, 602, 954, 802, 302, 0, 913, 397, 425, 844, 395, 796, 516, 420, 236, 854, 447 },
             //ADYASCENCIA PARA 18
             { 1328, 600, 291, 991, 1148, 1211, 826, 606, 789, 729, 1520, 711, 1089, 328, 928, 933, 913, 0, 960, 1056, 89, 514, 526, 1003, 1051, 898, 351, 469 },
             //ADYASCENCIA PARA 19
             { 490, 540, 626, 817, 1335, 373, 1553, 981, 615, 392, 2032, 414, 915, 890, 1115, 95, 397, 960, 0, 187, 895, 446, 391, 829, 154, 161, 1043, 636 },
              //ADYASCENCIA PARA 20
              { 481, 636, 813, 867, 1385, 364, 1610, 1038, 665, 480, 2082, 510, 965, 1077, 1165, 123, 425, 1056, 187, 0, 972, 538, 578, 879, 33, 189, 1135, 728 },
               //ADYASCENCIA PARA 21
               { 1244, 511, 300, 902, 1046, 1127, 737, 517, 700, 664, 1431, 646, 1000, 417, 826, 849, 844, 89, 895, 972, 0, 449, 615, 914, 967, 852, 262, 380},
                //ADYASCENCIA PARA 22
                { 810, 171, 344, 542, 1029, 693, 1072, 500, 340, 215, 1766, 197, 640, 559, 809, 416, 395, 514, 446, 538, 449, 0, 401, 554, 533, 360, 597, 190 },
                 //ADYASCENCIA PARA 23
                 { 881, 572, 235, 943, 1430, 764, 1352, 901, 741, 616, 2046, 598, 1041, 499, 1210, 486, 796, 526, 391, 578, 615, 401, 0, 955, 545, 552, 877, 591},
                  //ADYASCENCIA PARA 24
                  { 1145, 460, 898, 416, 506, 1034, 1257, 595, 214, 491, 1203, 437, 446, 1331, 286, 756, 516, 1003, 829, 879, 914, 554, 955, 0, 874, 690, 850, 534 },
                  //ADYASCENCIA PARA 25
                  { 513, 631, 780, 862, 1380, 396, 1605, 1033, 660, 483, 2077, 505, 960, 1044, 1160, 118, 420, 1051, 154, 33, 967, 533, 545, 874, 0, 184, 1130, 723 },
                  //ADYASCENCIA PARA 26
                  { 461, 497, 704, 678, 1195, 344, 1432, 938, 476, 349, 1893, 371, 776, 1041, 976, 66, 236, 898, 161, 189, 852, 360, 552, 690, 184, 0, 957, 550 },
                  //ADYASCENCIA PARA 27
                  { 1407, 538, 642, 929, 784, 1290, 475, 255, 727, 719, 1169, 665, 1027, 679, 564, 1012, 854, 351, 1043, 1135, 262, 597, 877, 850, 1130, 957, 0, 407 },
                    //ADYASCENCIA PARA 28
                  { 1000, 131, 534, 522, 839, 883, 882, 310, 320, 312, 1576, 258, 620, 797, 619, 605, 447, 469, 636, 728, 380, 190, 591, 534, 723, 550, 407, 0 }
            };

            return x;
        }
        protected static Grafiurri AntiHour()
        {
            Grafiurri grafin = new Grafiurri();

            for (int i = 1; i < 29; i++)
            {
                grafin.AgregarVertice(new Vertice("" + i));
            }


            //PARA EL NODO 1
            grafin.crearArco(new Vertice("1").Nombre, new Vertice("4").Nombre, 701);

            grafin.crearArco(new Vertice("1").Nombre, new Vertice("13").Nombre, 669);

            grafin.crearArco(new Vertice("1").Nombre, new Vertice("6").Nombre, 117);

            //PARA EL NODO 2

            grafin.crearArco(new Vertice("2").Nombre, new Vertice("9").Nombre, 245);
            grafin.crearArco(new Vertice("2").Nombre, new Vertice("12").Nombre, 137);
            grafin.crearArco(new Vertice("2").Nombre, new Vertice("22").Nombre, 171);


            //PARA EL NODO 3
            grafin.crearArco(new Vertice("3").Nombre, new Vertice("18").Nombre, 281);
            grafin.crearArco(new Vertice("3").Nombre, new Vertice("19").Nombre, 638);
            grafin.crearArco(new Vertice("3").Nombre, new Vertice("23").Nombre, 235);

            grafin.crearArco(new Vertice("3").Nombre, new Vertice("14").Nombre, 317);

            //PARA EL NODO 4

            grafin.crearArco(new Vertice("4").Nombre, new Vertice("13").Nombre, 98);
            grafin.crearArco(new Vertice("4").Nombre, new Vertice("1").Nombre, 701);

            grafin.crearArco(new Vertice("4").Nombre, new Vertice("9").Nombre, 202);

            //PARA EL NODO 5
            grafin.crearArco(new Vertice("5").Nombre, new Vertice("11").Nombre, 705);
            grafin.crearArco(new Vertice("5").Nombre, new Vertice("15").Nombre, 220);


            //PARA EL NODO 6
            grafin.crearArco(new Vertice("6").Nombre, new Vertice("1").Nombre, 117);
            grafin.crearArco(new Vertice("6").Nombre, new Vertice("16").Nombre, 288);
           


            //PARA EL NODO 7
            grafin.crearArco(new Vertice("7").Nombre, new Vertice("11").Nombre, 695);
            grafin.crearArco(new Vertice("7").Nombre, new Vertice("8").Nombre, 662);
            grafin.crearArco(new Vertice("7").Nombre, new Vertice("27").Nombre, 475);

            //PARA EL NODO 8
            grafin.crearArco(new Vertice("8").Nombre, new Vertice("7").Nombre, 662);
            grafin.crearArco(new Vertice("8").Nombre, new Vertice("15").Nombre, 309);
            grafin.crearArco(new Vertice("8").Nombre, new Vertice("28").Nombre, 310);
            grafin.crearArco(new Vertice("8").Nombre, new Vertice("27").Nombre, 268);




            //PARA EL NODO 9
            grafin.crearArco(new Vertice("9").Nombre, new Vertice("24").Nombre, 214);
            grafin.crearArco(new Vertice("9").Nombre, new Vertice("4").Nombre, 202);
            grafin.crearArco(new Vertice("9").Nombre, new Vertice("17").Nombre, 321);
            grafin.crearArco(new Vertice("9").Nombre, new Vertice("2").Nombre, 245);
            grafin.crearArco(new Vertice("9").Nombre, new Vertice("28").Nombre, 320);

            //PARA EL NODO 10
            grafin.crearArco(new Vertice("10").Nombre, new Vertice("12").Nombre, 54);
            grafin.crearArco(new Vertice("10").Nombre, new Vertice("16").Nombre, 381);

            //PARA EL NODO 11
            grafin.crearArco(new Vertice("11").Nombre, new Vertice("5").Nombre, 705);
            grafin.crearArco(new Vertice("11").Nombre, new Vertice("7").Nombre, 695);


            //PARA EL NODO 12
            grafin.crearArco(new Vertice("12").Nombre, new Vertice("2").Nombre, 137);
            grafin.crearArco(new Vertice("12").Nombre, new Vertice("10").Nombre, 54);


            // PARA EL NODO 13
            grafin.crearArco(new Vertice("13").Nombre, new Vertice("24").Nombre, 446);
            grafin.crearArco(new Vertice("13").Nombre, new Vertice("1").Nombre, 699);
            grafin.crearArco(new Vertice("13").Nombre, new Vertice("4").Nombre, 98);


            //PARA EL NODO 14
            grafin.crearArco(new Vertice("14").Nombre, new Vertice("18").Nombre, 328);
            grafin.crearArco(new Vertice("14").Nombre, new Vertice("3").Nombre, 317);
            grafin.crearArco(new Vertice("14").Nombre, new Vertice("23").Nombre, 499);

            //PARA EL NODO 15
            grafin.crearArco(new Vertice("15").Nombre, new Vertice("5").Nombre, 220);
            grafin.crearArco(new Vertice("15").Nombre, new Vertice("24").Nombre, 286);
            grafin.crearArco(new Vertice("15").Nombre, new Vertice("8").Nombre, 309);




            //PARA EL NODO 16
            grafin.crearArco(new Vertice("16").Nombre, new Vertice("10").Nombre, 381);
            grafin.crearArco(new Vertice("16").Nombre, new Vertice("26").Nombre, 66);
            grafin.crearArco(new Vertice("16").Nombre, new Vertice("6").Nombre, 288);
            grafin.crearArco(new Vertice("16").Nombre, new Vertice("20").Nombre, 123);
            grafin.crearArco(new Vertice("16").Nombre, new Vertice("19").Nombre, 95);


            //PARA EL NODO 17
            grafin.crearArco(new Vertice("17").Nombre, new Vertice("9").Nombre, 321);
            grafin.crearArco(new Vertice("17").Nombre, new Vertice("26").Nombre, 259);


            //PARA EL NODO 18
            grafin.crearArco(new Vertice("18").Nombre, new Vertice("21").Nombre, 89);
            grafin.crearArco(new Vertice("18").Nombre, new Vertice("3").Nombre, 291);

            //PARA EL NODO 19
            grafin.crearArco(new Vertice("19").Nombre, new Vertice("3").Nombre, 638);
            grafin.crearArco(new Vertice("19").Nombre, new Vertice("16").Nombre, 95);
            grafin.crearArco(new Vertice("19").Nombre, new Vertice("23").Nombre, 391);

            //PARA EL NODO 20
            
            grafin.crearArco(new Vertice("20").Nombre, new Vertice("16").Nombre, 123);
            grafin.crearArco(new Vertice("20").Nombre, new Vertice("25").Nombre, 33);

            //PARA EL NODO 21
            grafin.crearArco(new Vertice("21").Nombre, new Vertice("27").Nombre, 262);
            grafin.crearArco(new Vertice("21").Nombre, new Vertice("28").Nombre, 380);
            grafin.crearArco(new Vertice("21").Nombre, new Vertice("22").Nombre, 449);
            grafin.crearArco(new Vertice("21").Nombre, new Vertice("18").Nombre, 89);


            //PARA EL NODO 22
            grafin.crearArco(new Vertice("22").Nombre, new Vertice("21").Nombre, 449);
            grafin.crearArco(new Vertice("22").Nombre, new Vertice("28").Nombre, 190);
            grafin.crearArco(new Vertice("22").Nombre, new Vertice("2").Nombre, 171);
            grafin.crearArco(new Vertice("22").Nombre, new Vertice("23").Nombre, 401);

            //PARA EL NODO 23
            grafin.crearArco(new Vertice("23").Nombre, new Vertice("14").Nombre, 499);
            grafin.crearArco(new Vertice("23").Nombre, new Vertice("3").Nombre, 235);
            grafin.crearArco(new Vertice("23").Nombre, new Vertice("22").Nombre, 401);
            grafin.crearArco(new Vertice("23").Nombre, new Vertice("19").Nombre, 391);

            //PARA EL NODO 24
            grafin.crearArco(new Vertice("24").Nombre, new Vertice("15").Nombre, 286);
            grafin.crearArco(new Vertice("24").Nombre, new Vertice("13").Nombre, 446);
            grafin.crearArco(new Vertice("24").Nombre, new Vertice("9").Nombre, 214);




            //PARA EL NODO 25
            grafin.crearArco(new Vertice("25").Nombre, new Vertice("16").Nombre, 218);

            //PARA EL NODO 26
            grafin.crearArco(new Vertice("26").Nombre, new Vertice("17").Nombre, 259);
            grafin.crearArco(new Vertice("26").Nombre, new Vertice("16").Nombre, 66);

            //PARA EL NODO 27
            grafin.crearArco(new Vertice("27").Nombre, new Vertice("7").Nombre, 475);
            grafin.crearArco(new Vertice("27").Nombre, new Vertice("8").Nombre, 268);
            grafin.crearArco(new Vertice("27").Nombre, new Vertice("28").Nombre, 380);
            grafin.crearArco(new Vertice("27").Nombre, new Vertice("21").Nombre, 262);

            //PARA EL NODO 28
            grafin.crearArco(new Vertice("28").Nombre, new Vertice("27").Nombre, 390);
            grafin.crearArco(new Vertice("28").Nombre, new Vertice("8").Nombre, 310);
            grafin.crearArco(new Vertice("28").Nombre, new Vertice("9").Nombre, 320);
            grafin.crearArco(new Vertice("28").Nombre, new Vertice("2").Nombre, 131);
            grafin.crearArco(new Vertice("28").Nombre, new Vertice("21").Nombre, 380);

            return grafin;
        }
       
        protected static Grafiurri Hour()
        {
            Grafiurri grafin = new Grafiurri();

            for (int i = 1; i < 29; i++)
            {
                grafin.AgregarVertice(new Vertice("" + i));
            }


            //PARA EL NODO 1
            grafin.crearArco(new Vertice("1").Nombre, new Vertice("6").Nombre, 117);
            grafin.crearArco(new Vertice("1").Nombre, new Vertice("13").Nombre, 669);
            grafin.crearArco(new Vertice("1").Nombre, new Vertice("4").Nombre, 701);


            //PARA EL NODO 2

            grafin.crearArco(new Vertice("2").Nombre, new Vertice("9").Nombre, 245);
            grafin.crearArco(new Vertice("2").Nombre, new Vertice("12").Nombre, 137);
            grafin.crearArco(new Vertice("2").Nombre, new Vertice("22").Nombre, 171);

            //PARA EL NODO 3


            grafin.crearArco(new Vertice("3").Nombre, new Vertice("14").Nombre, 317);
            grafin.crearArco(new Vertice("3").Nombre, new Vertice("23").Nombre, 235);
            grafin.crearArco(new Vertice("3").Nombre, new Vertice("19").Nombre, 638);
            grafin.crearArco(new Vertice("3").Nombre, new Vertice("18").Nombre, 281);

            //PARA EL NODO 4
            grafin.crearArco(new Vertice("4").Nombre, new Vertice("9").Nombre, 202);
            grafin.crearArco(new Vertice("4").Nombre, new Vertice("1").Nombre, 701);
            grafin.crearArco(new Vertice("4").Nombre, new Vertice("13").Nombre, 98);




            //PARA EL NODO 5
            grafin.crearArco(new Vertice("5").Nombre, new Vertice("15").Nombre, 220);
            grafin.crearArco(new Vertice("5").Nombre, new Vertice("11").Nombre, 705);
            


            //PARA EL NODO 6
            grafin.crearArco(new Vertice("6").Nombre, new Vertice("16").Nombre, 288);
            grafin.crearArco(new Vertice("6").Nombre, new Vertice("1").Nombre, 117);


            //PARA EL NODO 7
            grafin.crearArco(new Vertice("7").Nombre, new Vertice("27").Nombre, 475);
            grafin.crearArco(new Vertice("7").Nombre, new Vertice("8").Nombre, 662);
            grafin.crearArco(new Vertice("7").Nombre, new Vertice("11").Nombre, 695);



            //PARA EL NODO 8
            grafin.crearArco(new Vertice("8").Nombre, new Vertice("27").Nombre, 268);
            grafin.crearArco(new Vertice("8").Nombre, new Vertice("28").Nombre, 310);
            grafin.crearArco(new Vertice("8").Nombre, new Vertice("15").Nombre, 309);
            grafin.crearArco(new Vertice("8").Nombre, new Vertice("7").Nombre, 662);

            //PARA EL NODO 9
            grafin.crearArco(new Vertice("9").Nombre, new Vertice("28").Nombre, 320);
            grafin.crearArco(new Vertice("9").Nombre, new Vertice("2").Nombre, 245);
            grafin.crearArco(new Vertice("9").Nombre, new Vertice("17").Nombre, 321);
            grafin.crearArco(new Vertice("9").Nombre, new Vertice("4").Nombre, 202);
            grafin.crearArco(new Vertice("9").Nombre, new Vertice("24").Nombre, 214);





            //PARA EL NODO 10
            grafin.crearArco(new Vertice("10").Nombre, new Vertice("16").Nombre, 381);
            grafin.crearArco(new Vertice("10").Nombre, new Vertice("12").Nombre, 54);


            //PARA EL NODO 11
            grafin.crearArco(new Vertice("11").Nombre, new Vertice("7").Nombre, 695);
            grafin.crearArco(new Vertice("11").Nombre, new Vertice("5").Nombre, 705);

            //PARA EL NODO 12
            grafin.crearArco(new Vertice("12").Nombre, new Vertice("10").Nombre, 54);
            grafin.crearArco(new Vertice("12").Nombre, new Vertice("2").Nombre, 137);



            // PARA EL NODO 13
            grafin.crearArco(new Vertice("13").Nombre, new Vertice("4").Nombre, 98);
            grafin.crearArco(new Vertice("13").Nombre, new Vertice("1").Nombre, 699);
            grafin.crearArco(new Vertice("13").Nombre, new Vertice("24").Nombre, 446);

            //PARA EL NODO 14
            grafin.crearArco(new Vertice("14").Nombre, new Vertice("23").Nombre, 499);

            grafin.crearArco(new Vertice("14").Nombre, new Vertice("3").Nombre, 317);
            grafin.crearArco(new Vertice("14").Nombre, new Vertice("18").Nombre, 328);


            //PARA EL NODO 15
            grafin.crearArco(new Vertice("15").Nombre, new Vertice("8").Nombre, 309);
            grafin.crearArco(new Vertice("15").Nombre, new Vertice("24").Nombre, 286);
            grafin.crearArco(new Vertice("15").Nombre, new Vertice("5").Nombre, 220);


            //PARA EL NODO 16

            grafin.crearArco(new Vertice("16").Nombre, new Vertice("19").Nombre, 95);

            grafin.crearArco(new Vertice("16").Nombre, new Vertice("20").Nombre, 123);

            grafin.crearArco(new Vertice("16").Nombre, new Vertice("6").Nombre, 288);

            grafin.crearArco(new Vertice("16").Nombre, new Vertice("26").Nombre, 66);
            grafin.crearArco(new Vertice("16").Nombre, new Vertice("10").Nombre, 381);


            //PARA EL NODO 17

            grafin.crearArco(new Vertice("17").Nombre, new Vertice("26").Nombre, 259);
            grafin.crearArco(new Vertice("17").Nombre, new Vertice("9").Nombre, 321);


            //PARA EL NODO 18

            grafin.crearArco(new Vertice("18").Nombre, new Vertice("3").Nombre, 291);
            grafin.crearArco(new Vertice("18").Nombre, new Vertice("21").Nombre, 89);

            //PARA EL NODO 19

            grafin.crearArco(new Vertice("19").Nombre, new Vertice("23").Nombre, 391);

            grafin.crearArco(new Vertice("19").Nombre, new Vertice("16").Nombre, 95);
            grafin.crearArco(new Vertice("19").Nombre, new Vertice("3").Nombre, 638);

            //PARA EL NODO 20

            grafin.crearArco(new Vertice("20").Nombre, new Vertice("16").Nombre, 123);
            grafin.crearArco(new Vertice("20").Nombre, new Vertice("25").Nombre, 33);

            //PARA EL NODO 21

            grafin.crearArco(new Vertice("21").Nombre, new Vertice("18").Nombre, 89);

            grafin.crearArco(new Vertice("21").Nombre, new Vertice("22").Nombre, 449);

            grafin.crearArco(new Vertice("21").Nombre, new Vertice("28").Nombre, 380);
            grafin.crearArco(new Vertice("21").Nombre, new Vertice("27").Nombre, 262);


            //PARA EL NODO 22

            grafin.crearArco(new Vertice("22").Nombre, new Vertice("23").Nombre, 401);

            grafin.crearArco(new Vertice("22").Nombre, new Vertice("2").Nombre, 171);

            grafin.crearArco(new Vertice("22").Nombre, new Vertice("28").Nombre, 190);
            grafin.crearArco(new Vertice("22").Nombre, new Vertice("21").Nombre, 449);

            //PARA EL NODO 23

            grafin.crearArco(new Vertice("23").Nombre, new Vertice("19").Nombre, 391);
            grafin.crearArco(new Vertice("23").Nombre, new Vertice("22").Nombre, 401);
            grafin.crearArco(new Vertice("23").Nombre, new Vertice("3").Nombre, 235);
            grafin.crearArco(new Vertice("23").Nombre, new Vertice("14").Nombre, 499);

            //PARA EL NODO 24

            grafin.crearArco(new Vertice("24").Nombre, new Vertice("9").Nombre, 214);
            grafin.crearArco(new Vertice("24").Nombre, new Vertice("13").Nombre, 446);
            grafin.crearArco(new Vertice("24").Nombre, new Vertice("15").Nombre, 286);

            //PARA EL NODO 25
            grafin.crearArco(new Vertice("25").Nombre, new Vertice("16").Nombre, 218);

            //PARA EL NODO 26

            grafin.crearArco(new Vertice("26").Nombre, new Vertice("16").Nombre, 66);
            grafin.crearArco(new Vertice("26").Nombre, new Vertice("17").Nombre, 259);

            //PARA EL NODO 27

            grafin.crearArco(new Vertice("27").Nombre, new Vertice("21").Nombre, 262);
            grafin.crearArco(new Vertice("27").Nombre, new Vertice("28").Nombre, 380);
            grafin.crearArco(new Vertice("27").Nombre, new Vertice("8").Nombre, 268);
            grafin.crearArco(new Vertice("27").Nombre, new Vertice("7").Nombre, 475);

            //PARA EL NODO 28

            grafin.crearArco(new Vertice("28").Nombre, new Vertice("21").Nombre, 380);
            grafin.crearArco(new Vertice("28").Nombre, new Vertice("22").Nombre, 190);
            grafin.crearArco(new Vertice("28").Nombre, new Vertice("2").Nombre, 131);
            grafin.crearArco(new Vertice("28").Nombre, new Vertice("9").Nombre, 320);
            grafin.crearArco(new Vertice("28").Nombre, new Vertice("8").Nombre, 310);
            grafin.crearArco(new Vertice("28").Nombre, new Vertice("27").Nombre, 390);

            return grafin;
        }
        
    }
}



