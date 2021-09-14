using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HeiligeBrigitta.ViewModels
{
    public class InfoPageViewModel : BaseViewModel
    {
        public ObservableCollection<string> Info { get; set; }

        public InfoPageViewModel()
        {
            Info = new ObservableCollection<string>();

            Info.Add("15 GEBETE DER HEILIGEN BRIGITTA ZUM LEIDENDEN HEILAND");

            Info.Add("Papst Pius IX. kannte diese Gebete und approbierte sie am 31. Mai 1862, indem er sie als der Wahrheit" +
                " entsprechend und zum großen Nutzen für das Heil der Seelen erachtete.");

            Info.Add("Im Jahr 1999 wurde die Hl. Brigitta von Schweden von Papst Johannes Paul II. zusammen mit Katharina von" +
                " Siena und Edith Stein zur Schutzheiligen Europas erklärt. Sie ist auch die Patronin von Schweden, der " +
                "Pilger und für einen sanften Tod. Sie ist die Mutter von Hl.Katharina von Schweden.");

            Info.Add("Schon lange hatte die hl. Birgitta den Herrn gebeten, ihr zu sagen, wie viele Streiche er in seinem " +
                "bitteren Leiden empfangen habe." + Environment.NewLine + "Eines Tages erschien der Heiland und sagte ihr:" +
                "\"Ich habe an meinem Körper 5480 Streiche erhalten. Wenn du diese verehren willst," +
                " so bete 15 Vater unser und 15 Ave Maria während eines Jahres jeden Tag.\" Und er lehrte die hl.Brigitta " +
                "die 15 dazugehörigen Gebete. \"Ist dieses Jahr vorbei, so hast du jede dieser 5480 Wunden verehrt.\"");

            Info.Add("Dann sprach der Heiland noch: \"Wer diese Gebete während eines Jahres jeden Tag verrichtet:\"");

            Info.Add("Wird 15 Seelen aus seiner Verwandtschaft aus dem Fegfeuer erlösen");

            Info.Add("15 Gerechte aus seiner Verwandtschaft werden die Gnade der Beharrlichkeit erlangen");

            Info.Add("15 Sünder aus seiner Verwandtschaft werden sich bekehren");

            Info.Add("Die Person selbst, welche sie betet, wird die ersten Stufen der Vollkommenheit erreichen");

            Info.Add("15 Tage vor ihrem Tode werde ich ihr meinen Kostbaren Leib reichen, damit sie durch denselben vor dem ewigen Hunger bewahrt werde; ich werde ihr mein Kostbares Blut zu trinken geben, um sie vor dem ewigen Durst zu bewahren");

            Info.Add("15 Tage vor ihrem Tod wird sie eine tiefe Reue und große Erkenntnis ihrer Sünden erhalten");

            Info.Add("Ich stelle das Zeichen meines siegreichen Kreuzes zwischen sie und den bösen Feind, damit sie vor seinen Fallstricken bewahrt bleibe");

            Info.Add("Vor ihrem Tod werde ich mit meiner teuren, vielgeliebten Mutter kommen und ihre Seele gnadenreich empfangen und sie in die ewigen Freuden einführen. Im Himmel wird sie eine besondere Erkenntnis meiner Gottheit erhalten, welche ich denen nicht mitteile, die diese Gebete nicht verrichten");

            Info.Add("Wenn jemand auch 30 Jahre in Todsünden dahingelebt hätte, sobald er ANDÄCHTIG diese Gebete verrichtet oder sich vornimmt, sie zu verrichten, wird der Herr ihm alle seine Sünden verzeihen und wird ihn gegen alle schlechten Versuchungen verteidigen");

            Info.Add("Er bewahrt seine fünf Sinne und bewahrt ihn vor einem jähen und unversehenen Tod und seine Seele vor der ewigen Verdammnis");

            Info.Add("Und alles, was er von Gott und der hl. Jungfrau verlangt, wird er ihm gewähren");

            Info.Add("Wer diese Gebete auch andere lehrt, dessen Freude und Verdienste werden in Ewigkeit dauern");

            Info.Add("An dem Ort, wo man diese Gebete verrichtet, ist Gott mit seiner Gnade gegenwärtig");
        }
    }
}
