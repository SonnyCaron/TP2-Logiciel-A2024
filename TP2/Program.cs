//ÉTAPE 1
using TP2;

Cegep cegepGranby = new Cegep("Cégep de Granby");
CoursStage C42063N = (CoursStage)cegepGranby.AjouterCoursAutorise(new CoursStage("420-63N-GR", "Stage d\'intégration", 12));
CoursStandard C420223 = (CoursStandard)cegepGranby.AjouterCoursAutorise(new CoursStandard("420-223-GR", "Support aux utilisateurs : Windows", 31));
CoursStandard C420623 = (CoursStandard)cegepGranby.AjouterCoursAutorise(new CoursStandard("420-623-GR", "Programmation et Internet", 31));
CoursStandard C420114 = (CoursStandard)cegepGranby.AjouterCoursAutorise(new CoursStandard("420-114-GR", "Programmation orientée objet   I", 31));
CoursStandard C420445 = (CoursStandard)cegepGranby.AjouterCoursAutorise(new CoursStandard("420-445-GR", "Modélisation et approches d\'analyse", 31));
CoursStandard C420124 = (CoursStandard)cegepGranby.AjouterCoursAutorise(new CoursStandard("420-124-GR", "Support aux utilisateurs : le matériel", 25));
CoursStandard C420134 = (CoursStandard)cegepGranby.AjouterCoursAutorise(new CoursStandard("420-134-GR", "Analyser les fonctions de travail", 31));
CoursStandard C420343 = (CoursStandard)cegepGranby.AjouterCoursAutorise(new CoursStandard("420-343-GR", "Création de sites Internet", 31));
CoursStandard C420243 = (CoursStandard)cegepGranby.AjouterCoursAutorise(new CoursStandard("420-243-GR", "Utilisation des outils de traitement multimédia", 31));
CoursStandard C420214 = (CoursStandard)cegepGranby.AjouterCoursAutorise(new CoursStandard("420-214-GR", "Programmation orientée objet II", 31));
CoursStandard C420433 = (CoursStandard)cegepGranby.AjouterCoursAutorise(new CoursStandard("420-433-GR", "Administration de réseaux : Novell", 25));
CoursStandard C420233 = (CoursStandard)cegepGranby.AjouterCoursAutorise(new CoursStandard("420-233-GR", "Utilisation de bases de données", 31));
CoursStandard C420314 = (CoursStandard)cegepGranby.AjouterCoursAutorise(new CoursStandard("420-314-GR", "Programmation orientée objet III", 31));
CoursStandard C420323 = (CoursStandard)cegepGranby.AjouterCoursAutorise(new CoursStandard("420-323-GR", "Support aux utilisateurs : Linux", 25));
CoursStandard C420613 = (CoursStandard)cegepGranby.AjouterCoursAutorise(new CoursStandard("420-613-GR", "Langage de programmation structurée (C++)", 31));
CoursStandard C420436 = (CoursStandard)cegepGranby.AjouterCoursAutorise(new CoursStandard("420-436-GR", "Programmation en environnement graphique", 31));
CoursStandard C42051P = (CoursStandard)cegepGranby.AjouterCoursAutorise(new CoursStandard("420-51P-GR", "Projet d\'intégration", 31));
CoursStandard C420523 = (CoursStandard)cegepGranby.AjouterCoursAutorise(new CoursStandard("420-523-GR", "Programmation orientée objet IV", 31));
CoursStandard C420335 = (CoursStandard)cegepGranby.AjouterCoursAutorise(new CoursStandard("420-335-GR", "Création d\'une application : environnement de base de données", 31));
CoursStandard C420423 = (CoursStandard)cegepGranby.AjouterCoursAutorise(new CoursStandard("420-423-GR", "Administration de réseaux : Microsoft", 25));
CoursStandard C420533 = (CoursStandard)cegepGranby.AjouterCoursAutorise(new CoursStandard("420-533-GR", "Approfondissement des réseaux", 31));
Console.WriteLine("ÉTAPE 1");
Console.WriteLine("Les cours du " + cegepGranby.Nom);
Console.WriteLine(cegepGranby.ToString());
Console.WriteLine();

//ÉTAPE 2
Programme Informatique = cegepGranby.AjouterProgramme("informatique");
Programme Administration = cegepGranby.AjouterProgramme("administration");
Session si1 = Informatique.AjouterSession("Session 1");
Session si2 = Informatique.AjouterSession("Session 2");
Session si3 = Informatique.AjouterSession("Session 3");

Session si4 = Informatique.AjouterSession("Session 4");
Session si5 = cegepGranby.ChercherProgramme("informatique").AjouterSession("Session 5");
Session si6 = cegepGranby.ChercherProgramme("informatique").AjouterSession("Session 6");
Session sa1 = Administration.AjouterSession("Session 1");
Session sa2 = Administration.AjouterSession("Session 2");
Session sa3 = Administration.AjouterSession("Session 3");
Session sa4 = Administration.AjouterSession("Session 4");
Session sa5 = cegepGranby.ChercherProgramme("administration").AjouterSession("Session 5");
Session sa6 = cegepGranby.ChercherProgramme("administration").AjouterSession("Session 6");
Console.WriteLine("ÉTAPE 2");
Console.WriteLine("Les programmes, les cours en gros et les sessions du " + cegepGranby.ToString());
Console.WriteLine();

//ÉTAPE 3
//si1.AjouterCours(C420114);
//si1.AjouterCours(C420124);
//si1.AjouterCours(C420134);
//si2.AjouterCours(C420214);
//si2.AjouterCours(C420223);
//si2.AjouterCours(C420233);
//si2.AjouterCours(C420243);
//cegepGranby.ChercherProgramme("informatique").ChercherSession("Session 3").AjouterCours(cegepGranby.ChercherCours("420-314-GR"));
//si3.AjouterCours(cegepGranby.ChercherCours("420-323-GR"));
//si3.AjouterCours(cegepGranby.ChercherCours("420-335-GR"));
//si3.AjouterCours(cegepGranby.ChercherCours("420-343-GR"));
//Console.WriteLine("ÉTAPE 3");
//Console.WriteLine("Les programmes, les cours en gros et les sessions du " + cegepGranby.ToString());