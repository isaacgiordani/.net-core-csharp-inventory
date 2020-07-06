using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Data
{
    public class SeedingService
    {
        private ApplicationDbContext _context;

        public SeedingService(ApplicationDbContext context) 
        {
            _context = context;
        }

        public void Seed() 
        {
            if (_context.Company.Any() ||
                _context.Employee.Any() ||
                _context.Equipment.Any()) 
            {
                return; //DB has been seeded
            }

            Company C1 = new Company(1, "IVM Projetos Automotivos do Brasil LTDA","Semcon","07.691.639/0003-71",true,DateTime.Now,DateTime.Now);

            Employee E1 = new Employee(1, "27536", "ABEL COSMO DE OLIVEIRA JUNIOR", "abel.oliveira@semcon.com", "", "20275019-6", "12382283726", true, DateTime.Now, DateTime.Now, C1);
            Employee E2 = new Employee(2, "25225", "ADRIANO DA SILVA", "adriano.silva@semcon.com", "", "12716602-3", "5716439730", true, DateTime.Now, DateTime.Now, C1);
            Employee E3 = new Employee(3, "27949", "ADRIANO DA SILVA FARIA", "adriano.faria@semcon.com", "", "24559955-1", "14222349836", true, DateTime.Now, DateTime.Now, C1);
            Employee E4 = new Employee(4, "28045", "AGUINALDO DARIO DO CARMO", "aguinaldo.carmo@semcon.com", "", "07699563-8", "95494472787", true, DateTime.Now, DateTime.Now, C1);
            Employee E5 = new Employee(5, "25369", "AIRAN TAKESHIRO SASAKI", "airan.sasaki@semcon.com", "", "14985969", "8292769633", true, DateTime.Now, DateTime.Now, C1);
            Employee E6 = new Employee(6, "28002", "ALANA GONCALVES RODRIGUES", "alana.rodrigues@semcon.com", "", "20803467-8", "12477240773", true, DateTime.Now, DateTime.Now, C1);
            Employee E7 = new Employee(7, "27452", "ALCIONE BONIFACIO CARRILHO SOARES", "alcione.soares@semcon.com", "", "11771250-5", "5635662722", true, DateTime.Now, DateTime.Now, C1);
            Employee E8 = new Employee(8, "10194", "ALENCAR NASCIMENTO PINTO FILHO", "alencar.filho@semcon.com", "extern.alencar.pinto@volkswagen.com.br", "10666175-4", "5507694710", true, DateTime.Now, DateTime.Now, C1);
            Employee E9 = new Employee(9, "24600", "ALEXANDRE DA SILVA ALMEIDA", "alexandre.almeida@semcon.com", "", "19717898", "8890527609", true, DateTime.Now, DateTime.Now, C1);
            Employee E10 = new Employee(10, "27610", "ALEXANDRE FERREIRA DA SILVA", "alexandre.silva@semcon.com", "extern.alexandre.silva3@volkswagen.com.br", "09973676-1", "9470810708", true, DateTime.Now, DateTime.Now, C1);
            Employee E11 = new Employee(11, "27700", "ALEXANDRE MAGNO LANDIM DIAS", "alexandre.dias@semcon.com ", "Extern.Alexandre.Dias@volkswagen.com.br", "55782719-X", "12467712680", true, DateTime.Now, DateTime.Now, C1);
            Employee E12 = new Employee(12, "27598", "ANA CAROLINA PAULINO PINTO", "ana.pinto@semcon.com", "", "15175183", "7288797600", true, DateTime.Now, DateTime.Now, C1);
            Employee E13 = new Employee(13, "25121", "ANA CAROLINA PEREIRA DE ALMEIDA", "ana.almeida2@semcon.com", "extern.ana.almeida@volkswagen.com.br", "23841221-7", "13605138764", true, DateTime.Now, DateTime.Now, C1);
            Employee E14 = new Employee(14, "25320", "ANA CAROLINA PEREIRA MARTINS", "ana.martins@semcon.com", "", "25659530-7", "14611388760", true, DateTime.Now, DateTime.Now, C1);
            Employee E15 = new Employee(15, "27632", "ANA CAROLLINE ANDRADE DE OLIVEIRA", "ana.carolline@semcon.com", "", "23606885-4", "13860871730", true, DateTime.Now, DateTime.Now, C1);
            Employee E16 = new Employee(16, "28031", "ANA CLARA ALVARENGA FACHARDO", "ana.fachardo@semcon.com", "", "17233714", "10614976669", true, DateTime.Now, DateTime.Now, C1);
            Employee E17 = new Employee(17, "27611", "ANA LUISA DE SOUZA SILVA", "ana.silva@semcon.com", "extern.ana.silva4@volkswagen.com.br", "19414053", "11262785723", true, DateTime.Now, DateTime.Now, C1);
            Employee E18 = new Employee(18, "25272", "ANA PAULA NEVES OLIVEIRA", "ana.oliveira@semcon.com", "extern.Ana.Oliveira@volkswagen.com.br", "14311520", "7054706609", true, DateTime.Now, DateTime.Now, C1);
            Employee E19 = new Employee(19, "28365", "Ana Quintino", "ana.quintino@semcon.com ", "", "", "", true, DateTime.Now, DateTime.Now, C1);
            Employee E20 = new Employee(20, "23078", "ANDERSON GOMES DE ASSIS", "anderson.assis@semcon.com", "", "12001168-9", "7956923743", true, DateTime.Now, DateTime.Now, C1);
            Employee E21 = new Employee(21, "28034", "ANDERSON GOMES FERREIRA", "anderson.ferreira@semcon.com", "", "08936648-8", "754637760", true, DateTime.Now, DateTime.Now, C1);
            Employee E22 = new Employee(22, "25216", "ANDERSON GUEDES FRANCISCO", "anderson.francisco@semcon.com", "extern.anderson.francisco@volkswagen.com.br", "21354552-8", "11995738760", true, DateTime.Now, DateTime.Now, C1);
            Employee E23 = new Employee(23, "27967", "ANDERSON LUIZ DAVID", "anderson.david@semcon.com", "", "17241812-4", "9707829850", true, DateTime.Now, DateTime.Now, C1);
            Employee E24 = new Employee(24, "27187", "ANDRE LUIZ GONCALVES PACHECO DA SILVA", "andre.pacheco@semcon.com", "extern.Andre.Silva4@volkswagen.com.br", "20704126-0", "14190723746", true, DateTime.Now, DateTime.Now, C1);
            Employee E25 = new Employee(25, "27133", "ANDRE LUIZ VIEIRA FUSCO FILHO", "andre.fusco@semcon.com", "", "20867915-9", "11974887740", true, DateTime.Now, DateTime.Now, C1);
            Employee E26 = new Employee(26, "28044", "ANDRE SILVA BARBOZA", "andre.barboza@semcon.com", "", "08583147-7", "4301438777", true, DateTime.Now, DateTime.Now, C1);
            Employee E27 = new Employee(27, "25189", "ANTONIO CARLOS MULLER", "antonio.muller@semcon.com", "extern.antonio.muller@volkswagen.com.br", "14245047-9", "6090533882", true, DateTime.Now, DateTime.Now, C1);
            Employee E28 = new Employee(28, "25366", "APOLO ALVES FERREIRA DA SILVA", "apolo.silva@semcon.com", "extern.Apolo.Silva@Volkswagen.com.br", "22409428-4", "12373350785", true, DateTime.Now, DateTime.Now, C1);
            Employee E29 = new Employee(29, "27120", "AUGUSTO ALVES DA SILVA", "augusto.silva@semcon.com", "extern.augusto.silva@volkswagen.com.br", "20994923-9", "13807497781", true, DateTime.Now, DateTime.Now, C1);
            Employee E30 = new Employee(30, "26220", "BARBARA BENEDETI DINALI SOUZA", "barbara.souza@semcon.com", "", "28147879-2", "16067376784", true, DateTime.Now, DateTime.Now, C1);
            Employee E31 = new Employee(31, "26717", "BIANCA ESTEVES CHAVES", "bianca.chaves@semcon.com", "", "217091172-2", "13760110770", true, DateTime.Now, DateTime.Now, C1);
            Employee E32 = new Employee(32, "27376", "BRUNA CARVALHO MELO FLORENCE DE OLIVEIRA", "bruna.oliveira@semcon.com", "", "43512916-8", "30117716855", true, DateTime.Now, DateTime.Now, C1);
            Employee E33 = new Employee(33, "25172", "BRUNNA SILVA SALGADO", "brunna.salgado@semcon.com", "", "21113646-0", "13915922714", true, DateTime.Now, DateTime.Now, C1);
            Employee E34 = new Employee(34, "27256", "BRUNO BEZERRA MACEDO", "bruno.macedo@semcon.com", "", "014089042000-6", "2656324394", true, DateTime.Now, DateTime.Now, C1);
            Employee E35 = new Employee(35, "25273", "BRUNO BRAGA AMARO", "bruno.amaro@semcon.com", "", "27883159-9", "13920753780", true, DateTime.Now, DateTime.Now, C1);
            Employee E36 = new Employee(36, "23518", "BRUNO KEBEC DA SILVA BASTOS", "bruno.bastos@semcon.com", "Extern.Bruno.Bastos1@volkswagen.com.br", "20937385-1", "12068685701", true, DateTime.Now, DateTime.Now, C1);
            Employee E37 = new Employee(37, "27618", "BRUNO LEONARDO ALVES DE CARVALHO", "bruno.alves@semcon.com", "extern.bruno.carvalho1@volkswagen.com.br", "020599205-0", "11031168788", true, DateTime.Now, DateTime.Now, C1);
            Employee E38 = new Employee(38, "27374", "BRUNO RIBEIRO LAURIA", "bruno.lauria@semcon.com", "", "11638239-1", "833961799", true, DateTime.Now, DateTime.Now, C1);
            Employee E39 = new Employee(39, "25278", "CAIO DE SOUZA DINIZ", "caio.diniz@semcon.com", "extern.Caio.Diniz@volkswagen.com.br", "20292074-0", "9945242776", true, DateTime.Now, DateTime.Now, C1);
            Employee E40 = new Employee(40, "25198", "CARLA LOBO MARTINS", "carla.martins@semcon.com", "extern.Carla.Martins@volkswagen.com.br", "24740976-6", "13657700790", true, DateTime.Now, DateTime.Now, C1);
            Employee E41 = new Employee(41, "26003", "CARLA MARIA DA SILVA", "carla.silva@semcon.com", "Extern.Carla.Silva@volkswagen.com.br", "27575124-6", "14730346718", true, DateTime.Now, DateTime.Now, C1);
            Employee E42 = new Employee(42, "27699", "CARLA NARCISO STEFANON", "carla.stefanon@semcon.com ", "Extern.Carla.Stefanon@volkswagen.com.br", "24289999-5", "14767431778", true, DateTime.Now, DateTime.Now, C1);
            Employee E43 = new Employee(43, "27200", "CARLOS ALBERTO MELLO SEBASTIANY", "carlos.sebastiany@semcon.com", "Extern.Carlos.Sebastiany@volkswagen.com.br", "16374701-5", "8463853846", true, DateTime.Now, DateTime.Now, C1);
            Employee E44 = new Employee(44, "24605", "CARLOS DOUGLAS REIS SARDELLA", "carlos.sardella@semcon.com", "Extern.Carlos.Sardella@volkswagen.com.br", "23765838-0", "13660223786", true, DateTime.Now, DateTime.Now, C1);
            Employee E45 = new Employee(45, "27535", "CARLOS EDUARDO DA SILVA FONTES", "carlos.fontes@semcon.com", "", "20518577-0", "12240132710", true, DateTime.Now, DateTime.Now, C1);
            Employee E46 = new Employee(46, "28155", "CARLOS EDUARDO DE FIGUEIREDO", "carlos.figueiredo@semcon.com", "", "7047040", "98921991620", true, DateTime.Now, DateTime.Now, C1);
            Employee E47 = new Employee(47, "28014", "CARLOS EDUARDO DOS SANTOS SILVA", "carlos.silva@semcon.com", "", "10864764-5", "8665090703", true, DateTime.Now, DateTime.Now, C1);
            Employee E48 = new Employee(48, "27167", "CARLOS EDUARDO ESMERALDO", "carlos.esmeraldo@semcon.com", "extern.Carlos.Esmeraldo@volkswagen.com.br", "11097084-5", "5328310713", true, DateTime.Now, DateTime.Now, C1);
            Employee E49 = new Employee(49, "28165", "Carlos Macedo", "Carlos.Macedo@semcon.com", "", "", "", true, DateTime.Now, DateTime.Now, C1);
            Employee E50 = new Employee(50, "26842", "CARLOS VINICIUS CARVALHO DE ALMEIDA", "carlos.vinicius@semcon.com", "extern.carlos.almeida@volkswagen.com.br", "020610360-8", "10095302751", true, DateTime.Now, DateTime.Now, C1);
            Employee E51 = new Employee(51, "27942", "CELIO AQUINO DE AMORIM", "celio.amorim@semcon.com", "", "5304855-6", "56973675891", true, DateTime.Now, DateTime.Now, C1);
            Employee E52 = new Employee(52, "28206", "CESAR HENRIQUE PONTES DE ANDRADE", "cesar.andrade@semcon.com", "", "08794022-7", "1636435718", true, DateTime.Now, DateTime.Now, C1);
            Employee E53 = new Employee(53, "27037", "CESAR ROGERIO BUSSOLA", "cesar.bussola@semcon.com", "Extern.Cesar.Bussola@volkswagen.com.br", "29894548-4", "587746610", true, DateTime.Now, DateTime.Now, C1);
            Employee E54 = new Employee(54, "27022", "CHARLES DINIZ DA SILVA", "charles.silva@semcon.com", "", "26613220-8", "12163327701", true, DateTime.Now, DateTime.Now, C1);
            Employee E55 = new Employee(55, "27338", "CLAISON TELES DOS SANTOS", "claison.santos@semcon.com", "", "21182731-9", "12595759850", true, DateTime.Now, DateTime.Now, C1);
            Employee E56 = new Employee(56, "27337", "CLAUDIO HENRIQUE AYRES", "claudio.ayres@semcon.com", "", "09556543-8", "419416757", true, DateTime.Now, DateTime.Now, C1);
            Employee E57 = new Employee(57, "27712", "CLEISON PEREIRA LIMA", "cleison.lima@semcon.com ", "Extern.Cleison.Lima@volkswagen.com.br", "56664044-2", "45826578858", true, DateTime.Now, DateTime.Now, C1);
            Employee E58 = new Employee(58, "25348", "CRISTIANE MIDORI HASHIMOTO", "cristiane.hashimoto@semcon.com", "", "12149253-2", "10725820748", true, DateTime.Now, DateTime.Now, C1);
            Employee E59 = new Employee(59, "28004", "CRISTIANE REZENDE FERNANDES", "cristiane.fernandes@semcon.com", "", "09549923-2", "7419064733", true, DateTime.Now, DateTime.Now, C1);
            Employee E60 = new Employee(60, "27633", "CRISTIELLEN OLIVEIRA SANTOS", "cristiellen.lima@semcon.com", "Extern.Cristiellen.Lima@volkswagen.com.br", "38079698-3", "43114112862", true, DateTime.Now, DateTime.Now, C1);
            Employee E61 = new Employee(61, "10208", "CYRO CARDOSO REIS MANCIO", "cyro.mancio@semcon.com", "extern.cyro.mancio@volkswagen.com.br", "11760645-9", "8047939726", true, DateTime.Now, DateTime.Now, C1);
            Employee E62 = new Employee(62, "23278", "DAFNY PAULO MIRANDA", "dafny.miranda@semcon.com", "extern.dafny.miranda@volkswagen.com.br", "26857116-3", "14227815770", true, DateTime.Now, DateTime.Now, C1);
            Employee E63 = new Employee(63, "27524", "DAIANA PAULINO VIDAL DE PAIVA SANTOS", "daiana.santos@semcon.com", "", "21377931-7", "10204094798", true, DateTime.Now, DateTime.Now, C1);
            Employee E64 = new Employee(64, "28028", "DANIEL ABBOTT ALBERTACCI", "daniel.albertacci@semcon.com", "", "27773868-8", "16069786750", true, DateTime.Now, DateTime.Now, C1);
            Employee E65 = new Employee(65, "25357", "DANIEL FARIA NASCIMENTO", "daniel.nascimento@semcon.com", "extern.Daniel.Nascimento@volkswagen.com.br", "13055497-5", "9837313730", true, DateTime.Now, DateTime.Now, C1);
            Employee E66 = new Employee(66, "26608", "DANIEL LANDIM DE SOUSA", "daniel.landim@semcon.com", "Extern.Daniel.Sousa@volkswagen.com.br", "10383250-7", "3270921730", true, DateTime.Now, DateTime.Now, C1);
            Employee E67 = new Employee(67, "27303", "DANIEL TAKANORI KEMMOKU", "Daniel.Kemmoku@semcon.com", "", "44241437-7", "34015699882", true, DateTime.Now, DateTime.Now, C1);
            Employee E68 = new Employee(68, "27234", "DANIELA MEDINA AOKI", "Daniela.Aoki@semcon.com", "", "42434472-5", "33002446840", true, DateTime.Now, DateTime.Now, C1);
            Employee E69 = new Employee(69, "28007", "DANIELA PINTO MONTEIRO", "daniela.monteiro@semcon.com", "", "08899803-4", "1803244704", true, DateTime.Now, DateTime.Now, C1);
            Employee E70 = new Employee(70, "27038", "DANIELE VIANA SIQUEIRA MOREIRA", "daniele.moreira@semcon.com", "", "12540963-1", "9941423741", true, DateTime.Now, DateTime.Now, C1);
            Employee E71 = new Employee(71, "24203", "DANIELLA INGRID COUTO ARRUDA", "daniella.arruda@semcon.com", "extern.Daniella.Arruda@volkswagen.com.br", "21202575-3", "16178806710", true, DateTime.Now, DateTime.Now, C1);
            Employee E72 = new Employee(72, "27347", "DANIELLI DIAS PEREIRA DANTAS", "Danielli.Dantas@semcon.com", "", "29336248-9", "13485304727", true, DateTime.Now, DateTime.Now, C1);
            Employee E73 = new Employee(73, "22898", "DANILO MARQUES DA SILVA", "danilo.marques@semcon.com", "Extern.Danilo.Silva2@volkswagen.com.br", "20554621-1", "12579107797", true, DateTime.Now, DateTime.Now, C1);
            Employee E74 = new Employee(74, "28290", "Dario Camargo", "dario.camargo@semcon.com", "", "", "", true, DateTime.Now, DateTime.Now, C1);
            Employee E75 = new Employee(75, "28066", "DEBORA LOPES SOARES DIAS CORREA", "debora.correa@semcon.com", "Extern.Debora.Correa@volkswagen.com.br", "29018574-3", "16940746765", true, DateTime.Now, DateTime.Now, C1);
            Employee E76 = new Employee(76, "22743", "DENIS DUTRA TERRA", "denis.terra@semcon.com", "extern.denis.terra@volkswagen.com.br", "12696045-9", "5587706737", true, DateTime.Now, DateTime.Now, C1);
            Employee E77 = new Employee(77, "26718", "DENNER WILLIANS DA SILVA", "denner.silva@semcon.com", "", "21177421-1", "14050451751", true, DateTime.Now, DateTime.Now, C1);
            Employee E78 = new Employee(78, "26793", "DEOFREY ALLEN BORLASA DOMINGO", "deofrey.domingo@semcon.com", "", "-0", "2669962726", true, DateTime.Now, DateTime.Now, C1);
            Employee E79 = new Employee(79, "28070", "DIEGO AUGUSTO NASCIMENTO SANTOS", "diego.santos@semcon.com", "", "20993403-3", "11698835752", true, DateTime.Now, DateTime.Now, C1);
            Employee E80 = new Employee(80, "26725", "DOUGLAS AVILA SILVA DE OLIVEIRA", "douglas.oliveira@semcon.com", "", "23991771-9", "14166312758", true, DateTime.Now, DateTime.Now, C1);
            Employee E81 = new Employee(81, "26454", "DOUGLAS DA SILVA LUCAS", "douglas.lucas@semcon.com", "", "11755457-6", "8227204775", true, DateTime.Now, DateTime.Now, C1);
            Employee E82 = new Employee(82, "28084", "EDER MISAC RIBEIRO PEIXOTO", "eder.peixoto@semcon.com", "", "24769832-7", "31524493805", true, DateTime.Now, DateTime.Now, C1);
            Employee E83 = new Employee(83, "26723", "EDGAR SALLES ALVES", "edgar.alves@semcon.com", "Extern.Edgar.Alves@volkswagen.com.br", "07133057-5", "95544780706", true, DateTime.Now, DateTime.Now, C1);
            Employee E84 = new Employee(84, "27918", "EDIMO PEREIRA DOS SANTOS", "edimo.santos@semcon.com", "", "06572650-7", "70773823700", true, DateTime.Now, DateTime.Now, C1);
            Employee E85 = new Employee(85, "24797", "EDSON ATSUHIRO YOKOYAMA", "edson.yokoyama@semcon.com", "extern.Edson.Yokoyama@volkswagen.com.br", "13336597", "9250525826", true, DateTime.Now, DateTime.Now, C1);
            Employee E86 = new Employee(86, "22774", "EDUARDO DE MENEZES VIEIRA", "eduardo.vieira@semcon.com", "", "08804303-9", "1246302780", true, DateTime.Now, DateTime.Now, C1);
            Employee E87 = new Employee(87, "28119", "EDUARDO RAMOS LAZARO", "eduardo.lazaro@semcon.com", "", "", "56785291887", true, DateTime.Now, DateTime.Now, C1);
            Employee E88 = new Employee(88, "25392", "EDUARDO ULISSES DA SILVA", "eduardo.silva@semcon.com", "extern.eduardo.silva@volkswagen.com", "50453418-X", "7080864623", true, DateTime.Now, DateTime.Now, C1);
            Employee E89 = new Employee(89, "25200", "ELAINE CRISTINA BATISTA ALOISIO", "elaine.aloisio@semcon.com", "extern.Elaine.Aloisio@volkswagen.com.br", "20813229-0", "12409179703", true, DateTime.Now, DateTime.Now, C1);
            Employee E90 = new Employee(90, "25358", "ELITON MOTA LAMIM", "eliton.lamim@semcon.com", "", "12716863-1", "9652452769", true, DateTime.Now, DateTime.Now, C1);
            Employee E91 = new Employee(91, "26677", "ELTON BARBOSA MACHADO", "elton.machado@semcon.com", "", "24309947-0", "12964887721", true, DateTime.Now, DateTime.Now, C1);
            Employee E92 = new Employee(92, "27997", "EMERSON FERREIRA DE CASTRO", "emerson.castro@semcon.com", "", "30667940-1", "28112151822", true, DateTime.Now, DateTime.Now, C1);
            Employee E93 = new Employee(93, "22802", "EVANDRO DE SOUZA PEREIRA", "evandro.pereira@semcon.com", "Extern.Evandro.Pereira@volkswagen.com.br", "35071853-2", "32869128835", true, DateTime.Now, DateTime.Now, C1);
            Employee E94 = new Employee(94, "25407", "EVERTON LUIZ BALBINO CAMPOS", "everton.campos@semcon.com", "Everton.Campos@volkswagen.com.br", "20333554-2", "5769379758", true, DateTime.Now, DateTime.Now, C1);
            Employee E95 = new Employee(95, "27706", "FABIANO VIANA DOS SANTOS", "fabiano.santos@semcon.com ", "extern.fabiano.santos1@volkswagen.com.br", "20943390-3", "10878356746", true, DateTime.Now, DateTime.Now, C1);
            Employee E96 = new Employee(96, "27714", "FABIO DOS SANTOS DA SILVA", "fabio.santos@semcon.com ", "Extern.Fabio.Silva3@volkswagen.com.br ", "48032950-3", "40531358852", true, DateTime.Now, DateTime.Now, C1);
            Employee E97 = new Employee(97, "27935", "FABIO LEITE REINATO", "fabio.reinato@semcon.com", "", "27332261-8", "17993648874", true, DateTime.Now, DateTime.Now, C1);
            Employee E98 = new Employee(98, "25359", "FABRICIO SEIXAS FRUCTUOSO MENDES DE CARVALHO", "fabricio.carvalho@semcon.com", "", "20963404-7", "10297841750", true, DateTime.Now, DateTime.Now, C1);
            Employee E99 = new Employee(99, "26808", "FERNANDO ARAUJO DA COSTA WARD", "fernando.ward@semcon.com", "", "24870895-0", "15050766761", true, DateTime.Now, DateTime.Now, C1);
            Employee E100 = new Employee(100, "25063", "FERNANDO BARBOSA", "fernando.barbosa@semcon.com", "extern.fernando.barbosa@volkswagen.com.br  ", "34333379-X", "28923094846", true, DateTime.Now, DateTime.Now, C1);
            Employee E101 = new Employee(101, "27615", "FILIPE BROISSE DA SILVA ALMEIDA", "filipe.almeida@semcon.com", "extern.filipe.almeida@volkswagen.com.br ", "22257970-8", "9945683713", true, DateTime.Now, DateTime.Now, C1);
            Employee E102 = new Employee(102, "27121", "FILIPE SACCHI DA SILVA", "filipe.sacchi@semcon.com", "Extern.Filipe.Silva1@volkswagen.com.br", "12919355-3", "10090233735", true, DateTime.Now, DateTime.Now, C1);
            Employee E103 = new Employee(103, "27475", "FLAVIA LORRANA DA SILVA", "flavia.silva@semcon.com", "extern.flavia.silva@volkswagen.com.br", "22380947-6", "12248306792", true, DateTime.Now, DateTime.Now, C1);
            Employee E104 = new Employee(104, "26504", "FLAVIO POLITO REIS", "flavio.reis@semcon.com", "extern.flavio.reis@volkswagen.com.br", "020120696-8", "10248825780", true, DateTime.Now, DateTime.Now, C1);
            Employee E105 = new Employee(105, "27948", "FRANCISCO CARLOS HENSEL DE ASSIS", "francisco.assis@semcon.com", "", "04530649-5", "65145119704", true, DateTime.Now, DateTime.Now, C1);
            Employee E106 = new Employee(106, "27596", "FREDERICO CARDOSO", "frederico.cardoso@semcon.com", "", "202006119-8", "9635027788", true, DateTime.Now, DateTime.Now, C1);
            Employee E107 = new Employee(107, "27494", "GABRIEL DE OLIVEIRA AGUIAR", "gabriel.aguiar@semcon.com", "", "27917511-1", "15056354708", true, DateTime.Now, DateTime.Now, C1);
            Employee E108 = new Employee(108, "26087", "GABRIEL DO NASCIMENTO RESENDE", "gabriel.resende@semcon.com", "", "20975031-4", "10054632714", true, DateTime.Now, DateTime.Now, C1);
            Employee E109 = new Employee(109, "28214", "GABRIEL HENRIQUE DO VALLE VIDIGAL AMADO", "gabriel.amado@semcon.com", "", "28578290-0", "14240854709", true, DateTime.Now, DateTime.Now, C1);
            Employee E110 = new Employee(110, "27889", "GERALDO VIANA DE CARVALHO", "geraldo.carvalho@semcon.com", "", "08793838-7", "753075709", true, DateTime.Now, DateTime.Now, C1);
            Employee E111 = new Employee(111, "26020", "GESSYCA DA SILVA TORRES GRILLO", "gessyca.grillo@semcon.com", "extern.gessyca.grillo@volkswagen.com.br ", "21883373-9", "14115120738", true, DateTime.Now, DateTime.Now, C1);
            Employee E112 = new Employee(112, "27987", "GILMAR MURILO MARQUES", "gilmar.marques@semcon.com", "", "5078720-0", "59341084768", true, DateTime.Now, DateTime.Now, C1);
            Employee E113 = new Employee(113, "28122", "Giovanny Fenelon", "giovanny.fenelon@semcon.com", "", "", "", true, DateTime.Now, DateTime.Now, C1);
            Employee E114 = new Employee(114, "27709", "GISLAINE GRACIANI VITORIANO DO NASCIMENTO", "gislaine.nascimento@semcon.com ", "Extern.Gislaine.Nascimento@volkswagen.com.br ", "11997683-5", "7663228740", true, DateTime.Now, DateTime.Now, C1);
            Employee E115 = new Employee(115, "27701", "GIULLIANE ELLENA DA SILVA CUNHA", "giulliane.cunha@semcon.com ", "extern.giulliane.cunha@volkswagen.com.br ", "27219092-1", "14292667756", true, DateTime.Now, DateTime.Now, C1);
            Employee E116 = new Employee(116, "27998", "GUSTAVO DA SILVA LOPES", "gustavo.lopes@semcon.com", "", "10279451-0", "5915442617", true, DateTime.Now, DateTime.Now, C1);
            Employee E117 = new Employee(117, "24406", "GUSTAVO LEITE DE CARVALHO", "gustavo.carvalho@semcon.com", "", "48553321-2", "44737931845", true, DateTime.Now, DateTime.Now, C1);
            Employee E118 = new Employee(118, "27093", "GUSTAVO VIEIRA DA SILVA", "gustavo.silva@semcon.com", "", "27978660-2", "15112339748", true, DateTime.Now, DateTime.Now, C1);
            Employee E119 = new Employee(119, "27355", "HELTON MACARIO", "helton.macario@semcon.com", "extern.helton.macario@volkswagen.com.br", "41950310-9", "22059294886", true, DateTime.Now, DateTime.Now, C1);
            Employee E120 = new Employee(120, "27606", "HERBERT GUIMARAES FRANCISCO", "herbert.francisco@semcon.com", "extern.herbert.francisco@volkswagen.com.br", "21740834-2", "15132703704", true, DateTime.Now, DateTime.Now, C1);
            Employee E121 = new Employee(121, "27092", "HERNANDES CORREA MOREIRA", "hernandes.moreira@semcon.com", "Extern.Hernandes.Moreira@volkswagen.com.br", "48668871-9", "5495924746", true, DateTime.Now, DateTime.Now, C1);
            Employee E122 = new Employee(122, "24040", "HUGO RESENDE FIGUEIRA BENTO", "hugo.bento@semcon.com", "", "23290218-9", "13131688742", true, DateTime.Now, DateTime.Now, C1);
            Employee E123 = new Employee(123, "28011", "IGOR CESAR MARTINS RIBEIRO", "igor.ribeiro@semcon.com", "", "23809406-4", "17455004729", true, DateTime.Now, DateTime.Now, C1);
            Employee E124 = new Employee(124, "27550", "IGOR MIGUEL NEVES DE CARVALHO", "igor.carvalho@semcon.com", "", "20685890", "8550295604", true, DateTime.Now, DateTime.Now, C1);
            Employee E125 = new Employee(125, "27612", "IGOR PEREIRA DA CUNHA", "igor.cunha@semcon.com", "extern.igor.cunha@volkswagen.com.br", "12075097-I", "5347268794", true, DateTime.Now, DateTime.Now, C1);
            Employee E126 = new Employee(126, "25236", "ISABELA INTORNE VIANA", "isabela.viana@semcon.com", "", "20564635-9", "12067413767", true, DateTime.Now, DateTime.Now, C1);
            Employee E127 = new Employee(127, "28169", "ISABELE RODRIGUES DOS SANTOS", "isabele.santos@semcon.com", "", "26573063-0", "14566804712", true, DateTime.Now, DateTime.Now, C1);
            Employee E128 = new Employee(128, "27936", "IURI CAETANO FREDERICO", "iuri.frederico@semcon.com", "", "11163807-8", "8213743709", true, DateTime.Now, DateTime.Now, C1);
            Employee E129 = new Employee(129, "27791", "JACQUELINE DUTRA MONTEIRO", "jacqueline.monteiro@semcon.com ", "", "21291064-0", "13142691782", true, DateTime.Now, DateTime.Now, C1);
            Employee E130 = new Employee(130, "27080", "JAMILLE DA SILVA CARVALHO TONA", "jamille.tona@semcon.com", "", "23822385-3", "13093063701", true, DateTime.Now, DateTime.Now, C1);
            Employee E131 = new Employee(131, "26109", "JANINE DE LIMA", "janine.lima@semcon.com", "extern.janine.lima@volkswagen.com.br", "12715720-4", "8797930741", true, DateTime.Now, DateTime.Now, C1);
            Employee E132 = new Employee(132, "23932", "JOAO PEDRO LEONE RAMOS", "joao.ramos@semcon.com", "", "27545995-6", "16547767779", true, DateTime.Now, DateTime.Now, C1);
            Employee E133 = new Employee(133, "28067", "JOAO VICTOR MENDES MADEIRA", "joao.madeira@semcon.com", "", "29094144-2", "13746835747", true, DateTime.Now, DateTime.Now, C1);
            Employee E134 = new Employee(134, "24366", "JOAO VICTOR SILVA MAGALHAES", "joao.magalhaes@semcon.com", "extern.Joao.Magalhaes@volkswagen.com.br", "28014912-1", "12419604709", true, DateTime.Now, DateTime.Now, C1);
            Employee E135 = new Employee(135, "28000", "JONAIRA EDVIRGES MARTINS DA CRUZ", "jonaira.cruz@semcon.com", "", "14293966-0", "8635325605", true, DateTime.Now, DateTime.Now, C1);
            Employee E136 = new Employee(136, "27553", "JONATHAN REZENDE SOUZA", "jonathan.souza@semcon.com", "", "24521188-3", "13608911707", true, DateTime.Now, DateTime.Now, C1);
            Employee E137 = new Employee(137, "25341", "JORDANA REZENDE LEME", "jordana.leme@semcon.com", "", "26802518-6", "14460392771", true, DateTime.Now, DateTime.Now, C1);
            Employee E138 = new Employee(138, "26724", "JOSE EDGARD MARCONDES FILHO", "jose.marcondes@semcon.com", "Extern.Jose.Marcondes@volkswagen.com.br", "13390348-5", "3295392803", true, DateTime.Now, DateTime.Now, C1);
            Employee E139 = new Employee(139, "26342", "JOSTER DE OLIVEIRA COTRIM BARBOSA", "joster.barbosa@semcon.com", "", "45724823-3", "38345952844", true, DateTime.Now, DateTime.Now, C1);
            Employee E140 = new Employee(140, "25226", "JULIANA RODRIGUES DE QUEIROZ", "juliana.queiroz@semcon.com", "juliana.queiroz@volkswagen.com.br", "11961000-4", "9433895770", true, DateTime.Now, DateTime.Now, C1);
            Employee E141 = new Employee(141, "25284", "JULIANO DE SOUZA TEIXEIRA", "juliano.teixeira@semcon.com", "extern.juliano.teixeira@volkswagen.com.br", "10540277-0", "4644961795", true, DateTime.Now, DateTime.Now, C1);
            Employee E142 = new Employee(142, "27707", "JULIO CESAR COSTA DE MIRANDA", "julio.miranda@semcon.com ", "Extern.Julio.Miranda@volkswagen.com.br ", "11947294-2", "10869049747", true, DateTime.Now, DateTime.Now, C1);
            Employee E143 = new Employee(143, "25157", "JUNIOR PEREIRA DE SOUZA", "junior.souza@semcon.com", "junior.souza@volkswagen.com.br", "12248840-6", "9929457712", true, DateTime.Now, DateTime.Now, C1);
            Employee E144 = new Employee(144, "25204", "KATIUCHA ALESSANDRA DA CUNHA EMERICK", "katiucha.cunha@semcon.com", "Extern.Katiucha.Emerick@volkswagen.com.br", "20532917-0", "10886838789", true, DateTime.Now, DateTime.Now, C1);
            Employee E145 = new Employee(145, "24567", "KLEBER VIANA FRANCA", "kleber.franca@semcon.com", "", "13286726-8", "11883835747", true, DateTime.Now, DateTime.Now, C1);
            Employee E146 = new Employee(146, "24250", "LAILA DA SILVA COSTA", "laila.silva@semcon.com", "", "29381654-2", "15666477706", true, DateTime.Now, DateTime.Now, C1);
            Employee E147 = new Employee(147, "24883", "LARISSA CRISTINA ANTONIO SECUNHA", "larissa.secunha@semcon.com", "larissa.secunha@volkswagen.com.br", "22542531-3", "12354281765", true, DateTime.Now, DateTime.Now, C1);
            Employee E148 = new Employee(148, "23598", "LEANDRO BARRA RUSSO", "leandro.russo@semcon.com", "Extern.Leandro.Russo@volkswagen.com.br", "12773445-7", "11654030724", true, DateTime.Now, DateTime.Now, C1);
            Employee E149 = new Employee(149, "28005", "LEANDRO DA SILVA DOS SANTOS", "leandro.santos@semcon.com", "", "21135155-6", "11912505711", true, DateTime.Now, DateTime.Now, C1);
            Employee E150 = new Employee(150, "22800", "LEANDRO DILBERTO SOUZA DA SILVA", "leandro.silva@semcon.com", "Extern.Leandro.Silva1@volkswagen.com.br", "24150493-5", "12881284795", true, DateTime.Now, DateTime.Now, C1);
            Employee E151 = new Employee(151, "28091", "LEANDRO MOSTACADA", "leandro.mostacada@semcon.com", "", "11089494-6", "7959875790", true, DateTime.Now, DateTime.Now, C1);
            Employee E152 = new Employee(152, "28325", "Leo Brandão", "leo.brandao@semcon.com", "", "", "", true, DateTime.Now, DateTime.Now, C1);
            Employee E153 = new Employee(153, "10204", "LEO HIROKAZU KATSUMOTO", "leo.katsumoto@semcon.com", "extern.leo.katsumoto@volkswagen.com.br", "30614310-0", "29258542819", true, DateTime.Now, DateTime.Now, C1);
            Employee E154 = new Employee(154, "1118", "LEO ZAMBOTI BRANDAO", "leo.brandao@semcon.com", "", "28188894-1", "13996658710", true, DateTime.Now, DateTime.Now, C1);
            Employee E155 = new Employee(155, "28026", "LEONARDO DA SILVA RODRIGUES", "leonardo.rodrigues@semcon.com", "", "", "8197101809", true, DateTime.Now, DateTime.Now, C1);
            Employee E156 = new Employee(156, "26798", "LEONARDO ESTEVAM PERIARD", "leonardo.periard@semcon.com", "extern.leonardo.periard@volkswagen.com.br", "11717299-9", "8553164705", true, DateTime.Now, DateTime.Now, C1);
            Employee E157 = new Employee(157, "28069", "LEONARDO LUIZ BERNARDES", "leonardo.bernardes@semcon.com", "", "36993838-0", "43481773846", true, DateTime.Now, DateTime.Now, C1);
            Employee E158 = new Employee(158, "23933", "LEONARDO QUEIROZ", "leonardo.queiroz@semcon.com", "", "11774963-0", "8073403757", true, DateTime.Now, DateTime.Now, C1);
            Employee E159 = new Employee(159, "25411", "LETICIA AMBROSIO DE SOUZA", "leticia.souza@semcon.com", "", "22457199-2", "12382286741", true, DateTime.Now, DateTime.Now, C1);
            Employee E160 = new Employee(160, "28213", "LETICIA CAMPOS CRUZ", "leticia.cruz@semcon.com", "", "25573813-0", "13968603710", true, DateTime.Now, DateTime.Now, C1);
            Employee E161 = new Employee(161, "27608", "LETICIA CRISTINA DOS SANTOS CARVALHO", "leticia.carvalho@semcon.com", "extern.leticia.carvalho@volkswagen.com.br", "23624587-4", "16470024785", true, DateTime.Now, DateTime.Now, C1);
            Employee E162 = new Employee(162, "28364", "Leticia Lopes", "leticia.lopes@semcon.com ", "", "", "", true, DateTime.Now, DateTime.Now, C1);
            Employee E163 = new Employee(163, "27790", "LEVI BATISTA DIAS DOS SANTOS", "levi.santos@semcon.com  ", "", "33597905-1", "31369238800", true, DateTime.Now, DateTime.Now, C1);
            Employee E164 = new Employee(164, "27188", "LI CHONGLIN", "li.chonglin@semcon.com", "", "", "6048831706", true, DateTime.Now, DateTime.Now, C1);
            Employee E165 = new Employee(165, "27807", "LIDIA DE CARVALHO", "lidia.carvalho@semcon.com", "", "19148951", "12708502611", true, DateTime.Now, DateTime.Now, C1);
            Employee E166 = new Employee(166, "27764", "LOHRAM ALEXANDRE DE ALMEIDA", "lohram.almeida@semcon.com ", "", "224115816-6", "13537143737", true, DateTime.Now, DateTime.Now, C1);
            Employee E167 = new Employee(167, "27702", "LUANA DA COSTA PEREIRA BAPTISTA DE SOUZA", "luana.souza@semcon.com ", "", "12511143-5", "11087518733", true, DateTime.Now, DateTime.Now, C1);
            Employee E168 = new Employee(168, "25340", "LUCAS DA CRUZ AMARANTE", "lucas.amarante@semcon.com", "extern.lucas.amarante@volkswagen.com.br", "32686864-1", "31913509850", true, DateTime.Now, DateTime.Now, C1);
            Employee E169 = new Employee(169, "28009", "LUCAS VIEIRA VARGAS", "lucas.vargas@semcon.com", "", "27889877-0", "15656992705", true, DateTime.Now, DateTime.Now, C1);
            Employee E170 = new Employee(170, "25265", "LUCIANO BARROS DE ABREU", "luciano.abreu2@semcon.com", "Extern.Luciano.Abreu@volkswagen.com.br", "12516298-2", "9097898781", true, DateTime.Now, DateTime.Now, C1);
            Employee E171 = new Employee(171, "26892", "LUIS ARMANDO PICCINO NAVARRO", "luis.navarro@semcon.com", "", "48180670-2", "41902826850", true, DateTime.Now, DateTime.Now, C1);
            Employee E172 = new Employee(172, "27483", "LUIS EDUARDO GUARDA", "luis.guarda@semcon.com", "", "25225281-0", "16790806873", true, DateTime.Now, DateTime.Now, C1);
            Employee E173 = new Employee(173, "27947", "LUIS EDUARDO SAMPAIO SALLES", "luis.salles@semcon.com", "", "12682083-6", "11061797732", true, DateTime.Now, DateTime.Now, C1);
            Employee E174 = new Employee(174, "26666", "LUIS FERNANDO DA SILVA LEITE", "luis.leite@semcon.com", "extern.Luis.Leite@volkswagen.com.br", "27106885-1", "10024787744", true, DateTime.Now, DateTime.Now, C1);
            Employee E175 = new Employee(175, "27616", "LUIZ CARLOS DOS SANTOS", "luiz.santos@semcon.com", "extern.luiz.santos@volkswagen.com.br", "33196706-6", "29497011830", true, DateTime.Now, DateTime.Now, C1);
            Employee E176 = new Employee(176, "28170", "LUIZ PAULO BITTENCOURT MAGALHAES", "Luiz.magalhaes@semcon.com", "", "042307801", "61867918749", true, DateTime.Now, DateTime.Now, C1);
            Employee E177 = new Employee(177, "28283", "LUIZ PAULO PEREIRA", "luiz.pereira@semcon.com", "", "MG12457451", "19035780", true, DateTime.Now, DateTime.Now, C1);
            Employee E178 = new Employee(178, "22940", "LUIZ RAPHAEL NUNES TORRES", "luiz.torres@semcon.com", "Luiz.Torres@volkswagen.com.br", "21755941-8", "13428249704", true, DateTime.Now, DateTime.Now, C1);
            Employee E179 = new Employee(179, "10240", "MARCELO DE ANDRADE VASCONCELOS", "marcelo.vasconcelos@semcon.com", "extern.marcelo.vasconcelos@volkswagen.com.br", "32993261-5", "8321978746", true, DateTime.Now, DateTime.Now, C1);
            Employee E180 = new Employee(180, "25255", "MARCELO ERIK DA SILVA ROQUE", "marcelo.roque@semcon.com", "extern.Marcelo.Roque@volkswagen.com.br", "28974778-8", "26026261800", true, DateTime.Now, DateTime.Now, C1);
            Employee E181 = new Employee(181, "27873", "MARCELO RAMOS DE OLIVEIRA", "marcelo.oliveira@semcon.com  ", "", "12342564-7", "8812684700", true, DateTime.Now, DateTime.Now, C1);
            Employee E182 = new Employee(182, "27382", "MARCIA CAROLINA CHAVES VIANA", "marcia.viana@semcon.com", "", "30503601-4", "15082090739", true, DateTime.Now, DateTime.Now, C1);
            Employee E183 = new Employee(183, "26807", "MARCIO CARDOSO DOS SANTOS", "marcio.santos@semcon.com", "", "8745836", "3288122693", true, DateTime.Now, DateTime.Now, C1);
            Employee E184 = new Employee(184, "26721", "MARCO ANTONIO QUIRINO", "marco.quirino@semcon.com", "Extern.Marco.Quirino@volkswagen.com.br", "18227663-6", "8524620854", true, DateTime.Now, DateTime.Now, C1);
            Employee E185 = new Employee(185, "26654", "MARCOS PAULO ARAUJO SAAR", "marcos.saar@semcon.com", "", "29081441-7", "17759610793", true, DateTime.Now, DateTime.Now, C1);
            Employee E186 = new Employee(186, "23007", "MARIANA RODRIGUES SOUZA DA SILVA MATSUMURA", "mariana.matsumura@semcon.com", "extern.Mariana.Matsumu@volkswagen.com.br", "20934884-6", "11856680711", true, DateTime.Now, DateTime.Now, C1);
            Employee E187 = new Employee(187, "27257", "MARIANA TEIXEIRA VILLELA SILVA", "mariana.silva@semcon.com", "", "20326048-4", "12985053722", true, DateTime.Now, DateTime.Now, C1);
            Employee E188 = new Employee(188, "28275", "MARINA DE SOUSA CARNEIRO", "marina.carneiro@semcon.com", "", "17117404", "10467147671", true, DateTime.Now, DateTime.Now, C1);
            Employee E189 = new Employee(189, "22773", "MARIO SERGIO DE OLIVEIRA", "mario.oliveira@semcon.com", "extern.mario.oliveira@volkswagen.com.br ", "29790130-8", "1438281692", true, DateTime.Now, DateTime.Now, C1);
            Employee E190 = new Employee(190, "25131", "MARISTELA MATTOS DE AZEVEDO", "maristela.azevedo@semcon.com", "", "06654244-0", "7334531809", true, DateTime.Now, DateTime.Now, C1);
            Employee E191 = new Employee(191, "27053", "MATEUS CARVALHO TELLES", "mateus.telles@semcon.com", "", "28762779-8", "15941473702", true, DateTime.Now, DateTime.Now, C1);
            Employee E192 = new Employee(192, "26961", "MATEUS DA SILVA LAGAIS PACHECO", "mateus.pacheco@semcon.com", "", "28271847-7", "15807765745", true, DateTime.Now, DateTime.Now, C1);
            Employee E193 = new Employee(193, "23157", "MATHEUS ASSUMPCAO TEIXEIRA", "matheus.teixeira@semcon.com", "", "28347652-1", "17074810754", true, DateTime.Now, DateTime.Now, C1);
            Employee E194 = new Employee(194, "27792", "MATHEUS COSTA CARVALHO", "matheus.carvalho@semcon.com ", "", "23298393-2", "15416910755", true, DateTime.Now, DateTime.Now, C1);
            Employee E195 = new Employee(195, "28284", "Matheus Franco", "matheus.franco@semcon.com ", "", "", "", true, DateTime.Now, DateTime.Now, C1);
            Employee E196 = new Employee(196, "28238", "MATHIAS DA SILVA CUNHA", "mathias.cunha@semcon.com", "", "21441679-4", "16194801743", true, DateTime.Now, DateTime.Now, C1);
            Employee E197 = new Employee(197, "25403", "MAURICIO MESQUITA DE ALMEIDA", "mauricio.almeida@semcon.com", "", "33282601-6", "31961381869", true, DateTime.Now, DateTime.Now, C1);
            Employee E198 = new Employee(198, "25237", "MAURO ANTONIO DE SIQUEIRA ALVARENGA JUNIOR", "mauro.alvarenga@semcon.com", "Extern.mauro.alvarenga@volkswagen.com.br    ", "22253309-3", "12201131740", true, DateTime.Now, DateTime.Now, C1);
            Employee E199 = new Employee(199, "27964", "MAURO MOREIRA DE ALMEIDA", "mauro.almeida@semcon.com", "", "05375165-7", "49826964700", true, DateTime.Now, DateTime.Now, C1);
            Employee E200 = new Employee(200, "24991", "MAX EMILIO DOS SANTOS RIBEIRO", "max.ribeiro@semcon.com", "", "21787749-7", "11679834754", true, DateTime.Now, DateTime.Now, C1);
            Employee E201 = new Employee(201, "27081", "MAYCON CAMPOS CAPACI", "maycon.capaci@semcon.com", "", "10827757-5", "8673906709", true, DateTime.Now, DateTime.Now, C1);
            Employee E202 = new Employee(202, "23016", "MICHEL PAIVA MALTA", "michel.malta@semcon.com", "extern.Michel.Malta@volkswagen.com.br", "20971079-7", "11016494700", true, DateTime.Now, DateTime.Now, C1);
            Employee E203 = new Employee(203, "27711", "NARA DAIANA DE OLIVEIRA", "Nara.oliveira@semcon.com ", "Extern.Nara.Oliveira@volkswagen.com.br ", "141136920", "6794547643", true, DateTime.Now, DateTime.Now, C1);
            Employee E204 = new Employee(204, "28309", "Natalia Martins", "natalia.martins@semcon.com ", "", "", "", true, DateTime.Now, DateTime.Now, C1);
            Employee E205 = new Employee(205, "27403", "NATAN DE CASTRO FERRAZ GUIMARAES", "natan.guimaraes@semcon.com", "", "15303356", "8812070639", true, DateTime.Now, DateTime.Now, C1);
            Employee E206 = new Employee(206, "26088", "NAYARA GONCALVES PIRES", "nayara.pires@semcon.com", "", "17036449", "12126767698", true, DateTime.Now, DateTime.Now, C1);
            Employee E207 = new Employee(207, "28008", "NAYARA SOUZA DE OLIVEIRA", "nayara.oliveira@semcon.com", "", "31333971-5", "18258165739", true, DateTime.Now, DateTime.Now, C1);
            Employee E208 = new Employee(208, "28318", "Nicacio Lucena", "nicacio.lucena@semcon.com ", "", "", "", true, DateTime.Now, DateTime.Now, C1);
            Employee E209 = new Employee(209, "27705", "OSMAR APARECIDO DA SILVA", "osmar.silva@semcon.com", "Extern.Osmar.Silva@volkswagen.com.br", "43191884-3", "34207123830", true, DateTime.Now, DateTime.Now, C1);
            Employee E210 = new Employee(210, "25033", "OSMAR DO NASCIMENTO", "osmar.nascimento@semcon.com", "", "06412413-4", "77703677787", true, DateTime.Now, DateTime.Now, C1);
            Employee E211 = new Employee(211, "27770", "PABLO ANIBAL DA SILVA", "pablo.silva@semcon.com", "", "12581102-6", "8430396713", true, DateTime.Now, DateTime.Now, C1);
            Employee E212 = new Employee(212, "23261", "PAMELLA DA SILVA LEMOS", "pamella.lemos@semcon.com", "extern.Pamella.Lemos@volkswagen.com.br", "22190099-6", "12833441738", true, DateTime.Now, DateTime.Now, C1);
            Employee E213 = new Employee(213, "25422", "PATRICIA ROCHA MAIA", "patricia.maia@semcon.com", "extern.Patricia.Maia@volkswagen.com.br", "23053709-4", "12786135796", true, DateTime.Now, DateTime.Now, C1);
            Employee E214 = new Employee(214, "22776", "PATRICK ALLAN DE OLIVEIRA KATO", "patrick.oliveira@semcon.com", "extern.Patrick.Kato@volkswagen.com.br", "27792570-7", "14945127778", true, DateTime.Now, DateTime.Now, C1);
            Employee E215 = new Employee(215, "27715", "PATRICK JUNIOR DE ANDRADE FREITAS", "patrick.freitas@semcon.com ", "", "23641247-4", "18467304731", true, DateTime.Now, DateTime.Now, C1);
            Employee E216 = new Employee(216, "25381", "PAULA FERNANDA DA ROCHA VICTOR", "paula.rocha@semcon.com", "extern.Paula.Rocha@volkswagen.com.br", "20758942-5", "14933386765", true, DateTime.Now, DateTime.Now, C1);
            Employee E217 = new Employee(217, "26893", "PAULA MIDORI KANEKO", "paula.kaneko@semcon.com", "", "47899131-9", "40947225803", true, DateTime.Now, DateTime.Now, C1);
            Employee E218 = new Employee(218, "25262", "PAULO CESAR RIGUEIRA", "paulo.rigueira@semcon.com", "Extern.Paulo.Rigueira@volkswagen.com.br", "08484899-3", "759505705", true, DateTime.Now, DateTime.Now, C1);
            Employee E219 = new Employee(219, "27165", "PAULO ROBERTO MARTINS CASTELLO BRANCO", "paulo.branco@semcon.com", "", "21581032-6", "11809803799", true, DateTime.Now, DateTime.Now, C1);
            Employee E220 = new Employee(220, "28033", "PEDRO ARAUJO DA COSTA WARD", "pedro.ward@semcon.com", "", "28432490-2", "16674728799", true, DateTime.Now, DateTime.Now, C1);
            Employee E221 = new Employee(221, "25276", "PEDRO SERGIO FIGUEREDO DA SILVEIRA", "pedro.silveira@semcon.com", "", "13182253-8", "9913286719", true, DateTime.Now, DateTime.Now, C1);
            Employee E222 = new Employee(222, "27565", "PETERSON SERGIO FERREIRA", "peterson.ferreira@semcon.com", "", "24786729-4", "13256177760", true, DateTime.Now, DateTime.Now, C1);
            Employee E223 = new Employee(223, "27999", "PRISCILA CARRARO DE SOUZA", "priscila.souza@semcon.com", "", "27473794-9", "5826443723", true, DateTime.Now, DateTime.Now, C1);
            Employee E224 = new Employee(224, "28068", "RAFAEL DA SILVA BORGES", "rafael.borges@semcon.com", "", "25476823-7", "14588921746", true, DateTime.Now, DateTime.Now, C1);
            Employee E225 = new Employee(225, "27919", "RAFAEL DE CARVALHO SILVA", "rafael.silva@semcon.com", "", "21338611-3", "11073609782", true, DateTime.Now, DateTime.Now, C1);
            Employee E226 = new Employee(226, "23936", "RAFAEL DUARTE FERREIRA REZENDE", "rafael.rezende@semcon.com", "", "23619342-1", "15709076767", true, DateTime.Now, DateTime.Now, C1);
            Employee E227 = new Employee(227, "27230", "RAFAEL PEREIRA MARQUES", "Rafael.Marques@semcon.com", "", "12926496-6", "10917931742", true, DateTime.Now, DateTime.Now, C1);
            Employee E228 = new Employee(228, "25156", "RAFAELA RODRIGUES BRANDAO", "rafaela.rodrigues@semcon.com", "extern.Rafaela.Brandao@Volkswagen.com.br ", "20280631-1", "10600177769", true, DateTime.Now, DateTime.Now, C1);
            Employee E229 = new Employee(229, "26720", "RALPH DE MORAES JUNIOR", "ralph.junior@semcon.com", "Extern.Ralph.Moraes@volkswagen.com.br", "20931156-3", "12951691858", true, DateTime.Now, DateTime.Now, C1);
            Employee E230 = new Employee(230, "26657", "RAMON CARVALHO SANTOS", "ramon.santos@semcon.com", "Extern.Ramon.Santos@volkswagen.com.br", "24370057-2", "15344321759", true, DateTime.Now, DateTime.Now, C1);
            Employee E231 = new Employee(231, "28003", "RAMON LANDIM ROMANO", "ramon.romano@semcon.com", "", "18555086-0", "12237084629", true, DateTime.Now, DateTime.Now, C1);
            Employee E232 = new Employee(232, "28113", "REGINALDO APARECIDO MACHADO", "reginaldo.machado@semcon.com", "", "33130970-1", "30126268835", true, DateTime.Now, DateTime.Now, C1);
            Employee E233 = new Employee(233, "25249", "RENATO OLIVEIRA DE PAULA", "renato.paula@semcon.com", "Extern.Renato.Paula@volkswagen.com.br ", "20264386-2", "10982542798", true, DateTime.Now, DateTime.Now, C1);
            Employee E234 = new Employee(234, "26795", "RENATO SILVA HORTA", "renato.horta@semcon.com", "extern.Renato.Horta@volkswagen.com.br", "27587386-7", "14744269729", true, DateTime.Now, DateTime.Now, C1);
            Employee E235 = new Employee(235, "28205", "RENATO SOARES DIAS", "renato.dias@semcon.com", "", "09080198-6", "4645616714", true, DateTime.Now, DateTime.Now, C1);
            Employee E236 = new Employee(236, "28153", "RIALMA PERES DA ROCHA", "rialma.rocha@semcon.com", "", "40952814-6", "36857390851", true, DateTime.Now, DateTime.Now, C1);
            Employee E237 = new Employee(237, "23937", "RICARDO POSSATTO", "ricardo.possato@semcon.com", "", "30527886-1", "9584520750", true, DateTime.Now, DateTime.Now, C1);
            Employee E238 = new Employee(238, "28027", "RICARDO SIQUEIRA TORRACA GARCIA SANCHES", "ricardo.sanches@semcon.com", "", "25384610-9", "14981476744", true, DateTime.Now, DateTime.Now, C1);
            Employee E239 = new Employee(239, "28012", "ROBERTO TARELHO PINHATA", "roberto.pinhata@semcon.com", "", "14267209-0", "4879718840", true, DateTime.Now, DateTime.Now, C1);
            Employee E240 = new Employee(240, "27809", "RODRIGO BAPTISTA DA SILVA", "rodrigo.silva@semcon.com", "", "25582476-2", "27679172889", true, DateTime.Now, DateTime.Now, C1);
            Employee E241 = new Employee(241, "25252", "RODRIGO MOREIRA", "rodrigo.moreira@semcon.com", "extern.Rodrigo.Moreira@volkswagen.com.br", "12199330-7", "5318022723", true, DateTime.Now, DateTime.Now, C1);
            Employee E242 = new Employee(242, "26843", "RODRIGO TEIXEIRA NUNES MARINHO", "rodrigo.marinho@semcon.com", "", "093874414-1", "4629610103", true, DateTime.Now, DateTime.Now, C1);
            Employee E243 = new Employee(243, "27277", "ROGELIO HENRY TORRES", "rogelio.torres@semcon.com", "", "9906306-2", "95549927853", true, DateTime.Now, DateTime.Now, C1);
            Employee E244 = new Employee(244, "28211", "ROGER BALMANT OLIVEIRA", "roger.oliveira@semcon.com", "", "29763485-9", "16907524759", true, DateTime.Now, DateTime.Now, C1);
            Employee E245 = new Employee(245, "Afastado", "ROMUALDO PAZZINI", "", "", "6306792-4", "3189628882", true, DateTime.Now, DateTime.Now, C1);
            Employee E246 = new Employee(246, "22775", "ROMULO FRANCO PEREIRA", "romulo.pereira@semcon.com", "extern.Romulo.Pereira@volkswagen.com.br", "21254441-5", "11398576735", true, DateTime.Now, DateTime.Now, C1);
            Employee E247 = new Employee(247, "25274", "RONALD ARAUJO DA CUNHA", "ronald.cunha@semcon.com", "extern.ronald.cunha@volkswagen.com.br", "20434053-3", "9933579703", true, DateTime.Now, DateTime.Now, C1);
            Employee E248 = new Employee(248, "26796", "SABRINE FRANCO RUELA POERTAS", "sabrine.poertas@semcon.com", "Extern.Sabrine.Poertas@volkswagen.com.br", "20055328-7", "9216333782", true, DateTime.Now, DateTime.Now, C1);
            Employee E249 = new Employee(249, "23035", "SAID MORAIS SIRIO ROCHA", "said.rocha@semcon.com", "", "14164089-83", "9793182709", true, DateTime.Now, DateTime.Now, C1);
            Employee E250 = new Employee(250, "27880", "TAIRRONE NOGUEIRA LOPES DA SILVA", "tairrone.silva@semcon.com  ", "", "11686254-1", "11998413748", true, DateTime.Now, DateTime.Now, C1);
            Employee E251 = new Employee(251, "23154", "THALITA DE OLIVEIRA RODRIGUES", "thalita.rodrigues@semcon.com", "extern.thalita.rodrigues@volkswagen.com.br", "26441130-7", "13951991755", true, DateTime.Now, DateTime.Now, C1);
            Employee E252 = new Employee(252, "23468", "THIAGO APARECIDO LOPES MEDEIROS", "thiago.medeiros@semcon.com", "extern.Thiago.Medeiros@volkswagen.com.br", "20517847-8", "12550384709", true, DateTime.Now, DateTime.Now, C1);
            Employee E253 = new Employee(253, "25291", "THIAGO PIRES MENDONCA", "thiago.mendonca@semcon.com", "", "20868314-4", "13721892704", true, DateTime.Now, DateTime.Now, C1);
            Employee E254 = new Employee(254, "27917", "THOMAS SEIXAS", "thomas.seixas@semcon.com", "", "21287625-4", "5858832709", true, DateTime.Now, DateTime.Now, C1);
            Employee E255 = new Employee(255, "28006", "TIAGO DA SILVA CASTRO", "tiago.castro@semcon.com", "", "20707296-8", "12369343770", true, DateTime.Now, DateTime.Now, C1);
            Employee E256 = new Employee(256, "25112", "TIAGO DA SILVA PARENTE", "tiago.parente@semcon.com", "", "020539457-0", "10681410779", true, DateTime.Now, DateTime.Now, C1);
            Employee E257 = new Employee(257, "23026", "UILE PIRES BORGES DA SILVA", "uile.silva@semcon.com", "Uile.Silva@volkswagen.com.br", "20654877-8", "5840528714", true, DateTime.Now, DateTime.Now, C1);
            Employee E258 = new Employee(258, "25137", "VAGNER PUTI", "vagner.puti@semcon.com", "extern.vagner.puti@volkswagen.com.br", "3765821-9", "12350990672", true, DateTime.Now, DateTime.Now, C1);
            Employee E259 = new Employee(259, "25099", "VAGNER TAVARES BALBINO", "vagner.balbino@semcon.com", "", "10460442-6", "5182080794", true, DateTime.Now, DateTime.Now, C1);
            Employee E260 = new Employee(260, "27963", "VALDEMAR PEREIRA DE FREITAS", "valdemar.freitas@semcon.com", "", "05660783-1", "70068640706", true, DateTime.Now, DateTime.Now, C1);
            Employee E261 = new Employee(261, "27703", "VALERIA GOUVEA DOS SANTOS", "valeria.santos@semcon.com ", "Extern.Valeria.Santos@volkswagen.com.br", "10998173-8", "7220095775", true, DateTime.Now, DateTime.Now, C1);
            Employee E262 = new Employee(262, "26221", "VICTOR GUILHERME FERREIRA DIONISIO", "victor.dionisio2@semcon.com", "", "20947821-3", "10482131705", true, DateTime.Now, DateTime.Now, C1);
            Employee E263 = new Employee(263, "27609", "VICTOR SALGADO DOMINGOS", "victor.salgado@semcon.com", "extern.victor.domingos@volkswagen.com.br", "28419529-4", "16465779730", true, DateTime.Now, DateTime.Now, C1);
            Employee E264 = new Employee(264, "27768", "VINICIUS CAMPOS PIETRA CARDOSO", "vinicius.cardoso@semcon.com", "", "12793920", "10205841651", true, DateTime.Now, DateTime.Now, C1);
            Employee E265 = new Employee(265, "27968", "VINICIUS DA CUNHA FARIAS", "vinicius.louzada@semcon.com", "", "24459212-7", "13475463750", true, DateTime.Now, DateTime.Now, C1);
            Employee E266 = new Employee(266, "22839", "VINICIUS DE CARVALHO SOUZA", "vinicius.souza@semcon.com", "extern.Vinicius.Souza2@volkswagen.com.br", "20762846-2", "10074515721", true, DateTime.Now, DateTime.Now, C1);
            Employee E267 = new Employee(267, "27597", "VINICIUS JOSE DE CARVALHO MENEZES", "vinicius.menezes@semcon.com", "", "24773745-5", "13252319756", true, DateTime.Now, DateTime.Now, C1);
            Employee E268 = new Employee(268, "27806", "VINICIUS MAGALHAES CAMPOS", "vinicius.campos@semcon.com", "", "18263304", "7064716607", true, DateTime.Now, DateTime.Now, C1);
            Employee E269 = new Employee(269, "27767", "VINICIUS RIBEIRO MACHADO DOS SANTOS", "Vinicius.Santos@semcon.com ", "", "20770748-0", "5766596731", true, DateTime.Now, DateTime.Now, C1);
            Employee E270 = new Employee(270, "26799", "VITOR DA SILVA SEIXAS", "vitor.seixas@semcon.com", "", "20650932-5", "13259928790", true, DateTime.Now, DateTime.Now, C1);
            Employee E271 = new Employee(271, "25139", "VITOR DIAS DE ALMEIDA SANTOS", "vitor.santos@semcon.com", "Extern.Vitor.Santos@volkswagen.com.br", "20787267-2", "10301446725", true, DateTime.Now, DateTime.Now, C1);
            Employee E272 = new Employee(272, "27969", "VITOR GUIMARAES CAPUCCI", "vitor.capucci@semcon.com", "", "309446387", "22138485803", true, DateTime.Now, DateTime.Now, C1);
            Employee E273 = new Employee(273, "27966", "VITOR LUIS DA SILVA JUNIOR", "vitor.silva@semcon.com", "", "11998254-4", "5608253744", true, DateTime.Now, DateTime.Now, C1);
            Employee E274 = new Employee(274, "28010", "WALTER ALEXANDRE RIBEIRO SALDANHA", "walter.saldanha@semcon.com", "", "21332809-9", "12966857722", true, DateTime.Now, DateTime.Now, C1);
            Employee E275 = new Employee(275, "25094", "WENDEL ALVIM TELES", "wendel.teles@semcon.com", "", "208643742", "12438029790", true, DateTime.Now, DateTime.Now, C1);
            Employee E276 = new Employee(276, "23692", "WESLEY LEE LUZ DOS SANTOS", "wesley.santos@semcon.com", "", "20572470-1", "11112533745", true, DateTime.Now, DateTime.Now, C1);
            Employee E277 = new Employee(277, "26313", "WILLIAM FERREIRA", "william.ferreira@semcon.com", "", "34219131-7", "32722365898", true, DateTime.Now, DateTime.Now, C1);
            Employee E278 = new Employee(278, "26880", "WILLIAM HEBERT SILVEIRA ALVES", "william.alves@semcon.com", "Extern.William.Alves@volkswagen.com.br", "20602726-0", "11153467763", true, DateTime.Now, DateTime.Now, C1);
            Employee E279 = new Employee(279, "27808", "WILLIAN GONCALVES", "willian.goncalves@semcon.com", "", "08693125-0", "767589742", true, DateTime.Now, DateTime.Now, C1);
            Employee E280 = new Employee(280, "27122", "WILLIE RIBEIRO PRUDENTE", "willie.prudente@semcon.com", "extern.Willie.Prudente@Volkswagen.com.br", "25621442-0", "11141477700", true, DateTime.Now, DateTime.Now, C1);
            Employee E281 = new Employee(281, "23935", "YERO AUGUSTO VIEIRA NETO", "yero.neto@semcon.com", "", "20740886-5", "11153767724", true, DateTime.Now, DateTime.Now, C1);
            Employee E282 = new Employee(282, "28366", "JULIA SANTAGATA", "julia.santagata@semcon.com ", "", "", "", true, DateTime.Now, DateTime.Now, C1);


            EquipmentType EqtT1 = new EquipmentType(1,"Celular","Samsung","J4");

            Equipment Ept1 = new Equipment(1,EqtT1,EqtT1.EquipmentTypeId,15,0,"BR-RSD-NB-0021",null,null,null,"4GB","i5-3340M","500GB","I HD G 4000","DCQZX1","2984257621",null, new DateTime(2020, 06, 23),"TESTANDO SEEDING",true,DateTime.Now,DateTime.Now,E1,E1.EmployeeId);


            _context.Company.AddRange(C1);
            _context.Employee.AddRange(
                E1,E2,E3,E4,E5,E6,E7,E8,E9,E10,
                E11, E12, E13, E14, E15, E16, E17, E18, E19, E20,
                E21, E22, E23, E24, E25, E26, E27, E28, E29, E30,
                E31, E32, E33, E34, E35, E36, E37, E38, E39, E40,
                E41, E42, E43, E44, E45, E46, E47, E48, E49, E50
                );
            _context.EquipmentType.AddRange(EqtT1);
            _context.Equipment.AddRange(Ept1);

            _context.SaveChanges();
        }
    }
}
