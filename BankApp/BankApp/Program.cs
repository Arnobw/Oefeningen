
            

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("hallo welkom bij de bank, \n hoeveel euro wilt u omruilen");
            double euro = Double.Parse(Console.ReadLine());
            double dollar = euro * 1.05;
            Console.WriteLine($"uw bedrag in dollar is {dollar}");

            string engi = @"
            #############################################
            ############__---~~~~~|~~~~~--__#############
            ########.-~~          |          ~~-.########
            #####.-~     .-~~~~-. |              ~-.#####
            ####/       {  o     }|                 \####
            ###/        /       / |                  \###
            ##|        `--r'   {  | ,___.-',          |##
            ##|          /      ~-|         ',        |##
            ##|---------{---------|----------'--------|##
            ##|          \        |         /         |##
            ##|           \       |        /          |##
            ###\         ~ ~~~~~~~|~~~~~~~~~ ~       /###
            ####\       ~ ~ ~ ~ ~ | ~ ~ ~ ~ ~ ~     /####
            #####`-_     ~ ~ ~ ~ ~|~ ~ ~ ~ ~ ~    _-'####
            ########`-__    ~ ~ ~ | ~ ~ ~ ~   __-'#######
            ############~~---_____|_____---~~############
            #############################################";
Console.WriteLine("geef 500 euro of de eend sterft :(");
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine( engi);
