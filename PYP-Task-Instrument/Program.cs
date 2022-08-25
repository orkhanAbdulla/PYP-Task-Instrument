// See https://aka.ms/new-console-template for more information

using PYP_Task_Instrument.Models;
using PYP_Task_Instrument.Models.Abstract;
using PYP_Task_Instrument.Utilis;

Instrument drum = new Drum
{
    Brand = "Sonor",
    Model = "zek258",
    Color = "gray",
    Description = "Sonor good brand",
    Cymbal = 5,
    Price = 2500
};

Instrument flute = new Flute()
{
    Brand = "Yamaha",
    Model = "yahu2584",
    Tonehole = 6,
    Description = "Yamaha good brand",
    Color="blue",
    Price=300

};
Instrument guitar = new Guitar
{
    Brand = "Ableton",
    Model = "zts300",
    CountOfWires = 8,
    Color="yellow",
    Description= "Ableton good brand",
    Price=255
};
Instrument piano = new Piano
{
 Brand= "Fazioli",
 Model="PI256",
 Keyboard=48,
 Color="Black",
 Description= "Fazioli good brand"

};

Instrument[] instruments = { drum, flute, guitar, piano };
PrintAllInstruments(instruments);


static void PrintAllInstruments(Instrument[] instruments)
{
	foreach (var instrument in instruments) {
        Helpers.Print("Enusturman: "+instrument.GetType().Name, ConsoleColor.Green);
        foreach (var item in instrument.GetType().GetProperties())
        {
            Helpers.Print("  "+item.Name+":"+ item.GetValue(instrument),ConsoleColor.Yellow);
        }
        Helpers.Print("Sound Funksionu:" + instrument.Sound(), ConsoleColor.Cyan);
        Helpers.Print("----------------------------",ConsoleColor.Red);
    }
}