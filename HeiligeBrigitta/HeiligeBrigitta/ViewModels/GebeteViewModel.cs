using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using HeiligeBrigitta.Models;
using HeiligeBrigitta.Views;

namespace HeiligeBrigitta.ViewModels
{
    public class GebeteViewModel : BaseViewModel
    {
        private ObservableCollection<FuenfzehnGebete> _gebetBrigitta;
        private string _vaterUnserAveMaria;
        private string _anrufung;

        public string VaterUnserAveMaria
        {
            get { return _vaterUnserAveMaria; }
            set { _vaterUnserAveMaria = value; OnPropertyChanged(); }
        }
        public string Anrufung
        {
            get { return _anrufung; }
            set { _anrufung = value; OnPropertyChanged(); }
        }
        public ObservableCollection<FuenfzehnGebete>  GebetBrigitta
        {
            get { return _gebetBrigitta; }
            set { _gebetBrigitta = value; }
        }

        public Command ZurueckSeiteEinsCommand { get; set; }

        public GebeteViewModel()
        {
            ZurueckSeiteEinsCommand = new Command(ZurueckSeiteEins);

            VaterUnserAveMaria = "Vater unser...Gegrüßet seist Du Maria...";
            Anrufung = "Anrufung: O Jesus, Sohn Gottes, geboren von Maria der Jungfrau, zum Heile der Menschen gekreuzigt, nun im Himmel herrschend, erbarme Dich unser!";

            GebetBrigitta = new ObservableCollection<FuenfzehnGebete>();
            GebetBrigitta = AddData();
            //this.AddData();
            //Title = "About";
            //OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        private void ZurueckSeiteEins(object obj)
        {
            //var refreshCurrentPage = new GebetePage();
            //Shell.Current.GoToAsync("GebetePage");
            GebetBrigitta = new ObservableCollection<FuenfzehnGebete>();
            GebetBrigitta = AddData();

        }

        private ObservableCollection<FuenfzehnGebete> AddData()
        {
            var addData = new ObservableCollection<FuenfzehnGebete>
            {
                new FuenfzehnGebete
                {
                    Hintergrundbild = "sky.jpg",

                    Ueberschrift = "VATER UNSER",

                    Gebet = "Vater unser im Himmel," + Environment.NewLine +
                    "geheiligt werde dein Name." + Environment.NewLine +
                    "Dein Reich komme." + Environment.NewLine +
                    "Dein Wille geschehe," + Environment.NewLine +
                    "wie im Himmel so auf Erden." + Environment.NewLine +
                    "Unser tägliches Brot gib uns heute." + Environment.NewLine +
                    "Und vergib uns unsere Schuld," + Environment.NewLine +
                    "wie auch wir vergeben unsern Schuldigern." + Environment.NewLine +
                    "Und führe uns nicht in Versuchung," + Environment.NewLine +
                    "sondern erlöse uns von dem Bösen." + Environment.NewLine +
                    "Denn dein ist das Reich und die Kraft" + Environment.NewLine +
                    "und die Herrlichkeit in Ewigkeit." + Environment.NewLine +
                    "Amen."

                },

                new FuenfzehnGebete
                {
                    Hintergrundbild = "asoggetti.jpg",

                    Ueberschrift = "DAS APOSTOLISCHE GLAUBENSBEKENNTNIS",
                    //GLAUBENSBEKENNTNIS
                    Gebet = "Ich glaube an Gott, den Vater, den Allmächtigen, den Schöpfer des Himmels und der Erde, und an Jesus Christus, seinen eingeborenen Sohn, unseren Herrn, empfangen durch den Heiligen Geist, geboren von der Jungfrau Maria, gelitten unter Pontius Pilatus, gekreuzigt, gestorben und begraben, hinabgestiegen in das Reich des Todes, am dritten Tage auferstanden von den Toten, aufgefahren in den Himmel; er sitzt zur Rechten Gottes, des allmächtigen Vaters, von dort wird er kommen, zu richten die Lebenden und die Toten. Ich glaube an den Heiligen Geist, die heilige katholische Kirche, Gemeinschaft der Heiligen, Vergebung der Sünden, Auferstehung der Toten und das ewige Leben. Amen"
                },

                new FuenfzehnGebete
                {
                    Hintergrundbild = "brigitta8.jpg",

                    Ueberschrift = "1. CHRISTI LEIDEN AM ÖLBERGE BIS ZU SEINER DORNERKRÖNUNG",

                    Gebet = "O Jesus, Du ewige Süßigkeit aller, die Dich lieben, Du Freund und Heiland der Sünder. Gedenke der tiefinnersten Betrübnis, die Du erduldet hast, als die Zeit deines heilsamsten Leidens, welches von Ewigkeit her in Deinem göttlichen Herzen bestimmt war, nun nahe herzu kam, als Du Deinen Jüngern die Füße gewaschen, Deinen Leib und Dein Blut ihnen zur Speise gereicht und mildreich sie getröstet hast und dann in der Fülle der Traurigkeit selbst bezeugtest: Betrübt ist meine Seele bis in den Tod," +
                    "bis zum Sterben! Gedenke aller Qual und Bedrängnis, die Du vor deinem Kreuzestod erlitten hast, als Du nach dreimaligem Gebete und blutigem Angstschweiß von Deinen Jüngern verraten, von Deinem Volke gefangen, falsch angeklagt, von Deinen Richtern ungerecht verurteilt, in der auserwählten Stadt, in hochfestlicher Zeit unschuldig verdammt, Deiner Kleider beraubt, mit Fäusten geschlagen, an eine Säule gebunden, gegeißelt, mit Dornen gekrönt und mit unzähligen anderen Unbilden mißhandelt wurdest. Durch das Andenken dieser Leiden verleihe mir, o Herr mein Gott, wahre Zerknirschung, würdige Genugtuung und Nachlassung aller meiner Sünden."
                    , Anschlussgebete = VaterUnserAveMaria,
                    Anrufung = Anrufung
                },

                new FuenfzehnGebete
                {
                    Hintergrundbild = "brigitta7.jpg",

                    Ueberschrift = "2. CHRISTI VERSPOTTUNG",

                    Gebet = "O Jesus, Du Freude der Engel und Lustgarten des Entzückens! Gedenke der Betrübnis und des Schauders, so Du ertragen, als alle Deine Feinde wie grimmige Löwen Dich umringten und mit Faustschlägen und Verspeiungen Dich anfielen.Durch diese Qualen und die ruchlosen Schmachworte, womit Deine Feinde Dich bedrängten, erlöse mich,o Herr Jesus, von allen meinen sichtbaren und unsichtbaren Feinden, und laß mich unter dem Schatten Deiner Flügel zum ewigen Heile gelangen."
                    , Anschlussgebete = VaterUnserAveMaria,
                    Anrufung = Anrufung
                },

                new FuenfzehnGebete
                {
                    Hintergrundbild = "brigitta2.jpg",

                    Ueberschrift = "3.CHRISTI ANNAGELUNG ANS KREUZ",

                    Gebet = "O Jesus, Du Werkmeister der Welt, der Du in Deiner Unermeßlichkeit Himmel und Erde umfassest!Gedenke des bitteren Schmerzes, den Du erduldet, als die grausamen Kriegsknechte Deine Hände und Füße mit scharfen Nägeln durchbohrten und an das Kreuz schlugen, wobei sie - Schmerz auf Schmerz häufend - Deine Glieder so gewaltsam nach der Länge und Breite des Kreuzes ausspannten, daß sie aus den Gelenken gerissen wurden. Durch das Andenken dieser bittersten Kreuzesqual bitte ich Dich, mir die heilige Furcht und Liebe Deines Namens zu erteilen."
                     , Anschlussgebete = VaterUnserAveMaria,
                    Anrufung = Anrufung
                },

                new FuenfzehnGebete
                {
                    Hintergrundbild = "brigitta14.jpg",

                    Ueberschrift = "4. CHRISTI GEBET FÜR SEINE KREUZIGER",

                    Gebet = "O Jesus, Du himmlischer Arzt!Gedenke der Todesschwäche, der Schmerzen, welche Du - erhöht am Kreuzesbaume - an allen Deinen verwundeten und zerfleischten Gliedern ertragen hast, also daß kein Schmerz dem Deinen glich, und vom Scheitel des Hauptes bis zu den Fußsohlen nichts Gesundes an Dir zu finden war;und wie Du dennoch, alle diese Qualen nicht beachtend, mildreich für Deine Feinde gebetet und gesprochen hast: \"Vater," +
                "vergib ihnen, denn sie wissen nicht, was sie tun!\" Durch diese Barmherzigkeit verleihe mir, daß die Erinnerung an Deine bittersten Leiden mir zur vollkommenen Verzeihung aller meiner Sünden und Verirrungen gereiche."
                 , Anschlussgebete = VaterUnserAveMaria,
                    Anrufung = Anrufung
                },


                new FuenfzehnGebete
                {
                    Hintergrundbild = "brigitta1.jpg",

                    Ueberschrift = "5. CHRISTI BARMHERZIGKEIT GEGEN REUMÜTIGE SÜNDER",

                    Gebet = "O Jesus, Du Spiegel der ewigen Klarheit! Gedenke jener Betrübnis, die Dein Herz bedrängte, als Du in dem Lichte Deiner allsehenden Weisheit zwar die selige Zukunft der Auserwählten sahest, welche durch die Verdienste Deines Leidens ihr Heil finden, aber auch die Verwerfung so vieler Gottlosen, die durch eigene Schuld in das ewige Verderben stürzen werden. Durch die unergründliche Tiefe Deiner Erbarmung, in welcher Du mit uns Sündern und Irrenden so schmerzliches Mitleiden empfunden, und die Du dem Räuber neben Dir erwiesen hast, als Du zu ihm sprachest: \"Heute wirst du bei mir im Paradiese sein\", bitte ich Dich, Du wollest auch mir in der Stunde des Todes Barmherzigkeit erzeigen."
                     , Anschlussgebete = VaterUnserAveMaria,
                    Anrufung = Anrufung
                },

                new FuenfzehnGebete
                {
                    Hintergrundbild = "brigitta15.jpg",

                    Ueberschrift = "6. CHRISTI TESTAMENT AM KREUZ",

                    Gebet = "O Jesus, König und Freund der Seelen, der Du allein aller Liebe und Sehnsucht würdig bist! Gedenke jener Betrübnis, die Du empfunden,als Du in Blöße und Elend, von allen Deinen Freunden verlassen, am Kreuz schwebtest und keinen anderen Tröster fandest als Deine geliebte Mutter, die in Bitterkeit ihrer Seele mit heiliger Treue Dir zur Seite stand und welche Du Deinem Jünger empfohlen, so wie Du den Jünger, anstatt Deiner, ihr zum Sohne gegeben hast, da Du sprachst: \"Frau, siehe deinen Sohn!\" und zum Jünger: \"Siehe, deine Mutter!\" Bei dem Schwerte des Schmerzes, das damals ihre Seele durchdrang, bitte ich Dich, o gütigster Jesus, daß Du in allen Trübsalen des Leibes und der Seele - am meisten in der Todesstunde - Deine mitleidvolle Erbarmung und Deinen Trost mir schenken wollest."
                     , Anschlussgebete = VaterUnserAveMaria,
                    Anrufung = Anrufung
                },

                new FuenfzehnGebete
                {
                    Hintergrundbild = "brigitta13.jpg",

                    Ueberschrift = "7. CHRISTI DEMUT",

                    Gebet = "O Jesus! Du Quelle der unerschöpflichen Gütigkeit, der Du aus tiefstem Verlangen am Kreuze sprachst: \"Mich dürstet!\", nämlich nach dem Heile des menschlichen Geschlechts, entzünde in unserem Herzen die Sehnsucht nach allen Übungen der wahrhaften Tugend und vertilge in uns gänzlich alle Begierlichkeit der Sinne, alle böse Lust und allen Durst nach Ergötzungen."
                     , Anschlussgebete = VaterUnserAveMaria,
                    Anrufung = Anrufung
                },

                new FuenfzehnGebete
                {
                    Hintergrundbild = "brigitta17.jpg",

                    Ueberschrift = "8. CHRISTI TRANK",

                    Gebet = "O Jesus, Du Süßigkeit des Herzens und unaussprechliche Freude der Dir ergebenen Seelen! Durch die Bitterkeit des Essigs und der Galle, die Du für mich verkostet hast, verleihe mir, daß ich in der Todesstunde zum Heile und Trost meiner Seele Dich würdig empfangen möge."
                 , Anschlussgebete = VaterUnserAveMaria,
                    Anrufung = Anrufung
                },

                new FuenfzehnGebete
                {   
                    Hintergrundbild = "brigitta9.jpg",

                    Ueberschrift = "9. CHRISTI ANGSTRUF AM KREUZ",

                    Gebet = "O Gott, Du herrschende Kraft und Jubel des Gemütes, gedenke der Qual und Bedrängnis, die Du gelitten, als Du im Herannahen Deines bittersten Todes und in unaussprechlicher Beraubung alles fühlbaren Trostes mit lauter Stimme ausriefest: \"Mein Gott, mein Gott, warum hast du mich verlassen!\" Durch diese Angst der scheinbaren Verlassenheit, womit Du von der ewigen Verstoßenheit uns erlöset hast, bitte ich Dich, Herr, unser Gott, daß Du in meinen Drangsalen mich niemals verlassen wollest."
                     , Anschlussgebete = VaterUnserAveMaria,
                    Anrufung = Anrufung
                },

                new FuenfzehnGebete
                {
                    Hintergrundbild = "brigitta3.jpg",

                    Ueberschrift = "10. CHRISTI VIELE WUNDEN",

                    Gebet = "O Jesus, Anfang und Ende, Kraft und Leben! Gedenke, daß Du vom Haupte bis zu den Fußsohlen Dich gänzlich für uns in das Meer der Leiden versenkt hast." +
                    "Durch die Größe und Tiefe Deiner schmerzlichsten Wunden lehre mich in Sünden Versunkenen durch wahren Liebesgehorsam Deine Gebote beachten."
                 , Anschlussgebete = VaterUnserAveMaria,
                    Anrufung = Anrufung
                },

                new FuenfzehnGebete
                {
                    Hintergrundbild = "brigitta11.jpg",

                    Ueberschrift = "11. CHRISTI TIEFE WUNDEN",

                    Gebet = "O Jesus, Du Abgrund der tiefsten Barmherzigkeit! Um der Tiefe Deiner Wunden willen, welche das Mark Deiner Gebeine durchdrangen, bitte ich Dich, ziehe mich aus dem Abgrund der Sünden hervor, und verbirg meine Seele in Deinen heiligen Wunden vor dem Angesicht Deines strafenden Zornes, damit ich nicht Deiner Gerechtigkeit anheimfalle."
                 , Anschlussgebete = VaterUnserAveMaria,
                    Anrufung = Anrufung
                },

                new FuenfzehnGebete
                {
                    Hintergrundbild = "brigitta5.jpg",

                    Ueberschrift = "12. CHRISTI BLUTENDE WUNDEN",

                    Gebet = "O Jesus, Du strahlendes Bild der Wahrheit,Zeichen der Einigkeit und Band der Liebe,gedenke der zahllosen Wunden, die Deinen ganzen Leib bedeckten und ihn mit Deinem heiligsten Blute färbten; gedenke der unbegreiflichen Leiden, die Du in Deinem reinsten Leibe für uns erduldet hast. Was hättest Du noch ferner tun sollen, was Du nicht getan hast? Ich bitte Dich, o gütigster Jesus, schreibe mit Deinem kostbaren Blute alle diese Wunden in mein Herz, damit ich Deinen Schmerz und Deinen Tod darin allzeit lese und in treuer Dankbarkeit dafür bis zum Ende verharre."
                     , Anschlussgebete = VaterUnserAveMaria,
                    Anrufung = Anrufung
                },

                new FuenfzehnGebete
                {
                    Hintergrundbild = "brigitta6.jpg",

                    Ueberschrift = "13. CHRISTI LETZTE ANGST",

                    Gebet = "O Jesus, unsterblicher und unüberwindlicher König! Gedenke der Schmerzen, die Du erlitten hast, als alle Kräfte Deines Lebens Dich gänzlich verließen und Du mit geneigtem Haupte sprachst: \"Es ist vollbracht!\" Durch diese Deine Todesangst erbarme Dich meiner in meiner letzten Stunde, wenn mein Gemüt bedrängt und mein Geist darniedergebeugt sein wird."
                     , Anschlussgebete = VaterUnserAveMaria,
                    Anrufung = Anrufung
                },

                new FuenfzehnGebete
                {
                    Hintergrundbild = "brigitta10.jpg",

                    Ueberschrift = "14. CHRISTI TOD",

                    Gebet = "O Jesus, Du Eingeborener des allerhöchsten Vaters, Abglanz und Ebenbild seiner Wesenheit!Gedenke jener innigsten Hingebung, womit Du dem Vater Deinen Geist übergeben hast, indem Du riefest: \"Vater, in deine Hände empfehle ich meinen Geist!\" Und wie Du als dann mit zerrissenem Leibe, mit gebrochenem Herzen Deine Barmherzigkeit über uns vollendet und so Deinen Geist aufgegeben hast.Durch diesen kostbaren Tod bitte ich Dich, o König der Heiligen, stärke mich im Streite gegen den Satan, die Welt und das Fleisch, damit ich - der Welt absterbend - Dir lebe und meine Seele endlich, wenn sie in der Stunde des Scheidens von ihrer Pilgerschaft zurückkehrt, mit erbarmender Liebe von Dir aufgenommen werde."
                     , Anschlussgebete = VaterUnserAveMaria,
                    Anrufung = Anrufung
                },

                new FuenfzehnGebete
                {
                    Hintergrundbild = "brigitta16.jpg",

                    Ueberschrift = "15. CHRISTI LETZTE GÄNZLICHE BLUTVERGIESSUNG",

                    Gebet = "O Jesus, Du wahrer und fruchtbarer Weinstock, in welchen wir eingepflanzt sind,gedenke jener überreichen Vergießung Deines Blutes, welches Du - gleich dem Safte der gepreßten Traube - vergossen, als Du aus Deiner durch die Lanze geöffneten Seite Blut und Wasser reichlich hervorquellen ließest, dergestalt, daß auch kein Tropfen zurückblieb, und Dein heiligster Leib - gleich einem Myrrhenbüschlein vertrocknet - hoch am Kreuze schwebte. Durch diese Vergießung Deines köstlichen Blutes stärke meine Seele in ihrem Todesstreite und lasse sie - von allen Flecken rein - vor Dir erscheinen."
                     , Anschlussgebete = VaterUnserAveMaria,
                    Anrufung = Anrufung
                },

                new FuenfzehnGebete
                {
                    Hintergrundbild = "brigitta12.jpg",
                    Ueberschrift = "SCHLUSS & KIRCHENGEBET",

                    Gebet = "Nimm an, o Jesus, dieses Gebet in jener überherrlichen Liebe, in welcher Du alle Wunden Deines heiligsten Leibes für uns getragen hast; erbarme Dich meiner und aller mit Sünde beladenen, und verleihe allen gläubigen Seelen - den lebendigen wie den abgeschiedenen - Gnade, Verzeihung und das ewige Leben."
                    + Environment.NewLine + Environment.NewLine +
                    "Herr unser Gott, Du hast der seligen Brigitta durch Deinen eingeborenen Sohn himmlische Geheimnisse offenbart. Gib auf ihre fromme Fürbitte hin, daß wir, Deine Diener, bei der Offenbarung Deiner ewigen Herrlichkeit von jubelnder Freude erfüllt werden durch Christus unseren Herrn." +
                    " Amen."

                    , Anschlussgebete = VaterUnserAveMaria,
                    Anrufung = Anrufung

                }
            };

            return addData;

        }
       

    }
}