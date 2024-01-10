using system; 
using System.collections.Generic;
  

namespace Knowledgecheck2
class Pictures
{ static void main(string[] args)

    public string Genre { get; set; }
    public string Theme { get; set; }
    public string Season { get; set; }
        }

class Family : Pictures
    public string Familyname {  get; set; }
    public string Familyyear {  get; set; }


Console.WriteLine("What kind pictures do you want to add? ");
var numberOfPictures = int.Parse(Console.ReadLine());

var PictureList = new List<Pictures>();

for (int i = 0; i < numberOfPictures; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var Family = new Family();

    Console.WriteLine("Enter the value for ");
    Family.Family = Console.ReadLine();

    PictureList.Add(Summer);
    PictureList.Add(Winter);
    PictureList.Add(Fall);
    PictureList.Add(Spring);
    PictureList.Add(2023);
    PictureList.Add(2022);
    PictureList.Add(2021);
    PictureList.Add(2020);
    PictureList.Add(modeling);
    PictureList.Add(modelingheadshot);
    PictureList.Add(nature);
    PictureList.Add(animals);
    PictureList.Add(Halloween);
    PictureList.Add(Christmas);
    PictureList.Add(Birthday);
    PictureList.Add(Valentinesday);

}

// Print out the list of records using Console.WriteLine()