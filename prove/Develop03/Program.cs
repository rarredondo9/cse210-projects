using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();

        Reference reference1 = new Reference("Doctrina and Covenants", 121, 7, 8);
        string text1 = "My son, peace be unto thy soul; thine adversity and thine afflictions shall be but a small moment; " + 
        "And then, if thou endure it well, God shall exalt thee on high; thou shalt triumph over all thy foes. " + 
        "Doctrine and Covenants 121:7-8";
        Scripture scripture1 = new Scripture(reference1, text1);
        library.AddScripture(scripture1);

        Reference reference2 = new Reference("Ether", 12, 4);
        string text2 = "Wherefore, whoso believeth in God might with surety hope for a better world, yea, even a place at the right hand of God, which hope cometh of faith, maketh an anchor to the souls of men, which would make them sure and steadfast, always abounding in good works, being led to glorify God."+
        "Ether 12:4";
        Scripture scripture2 = new Scripture(reference2, text2);
        library.AddScripture(scripture2);

        Reference reference3 = new Reference("Mosiah", 2, 41);
        string text3 = "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it."+
        "Mosiah 2:41";
        Scripture scripture3 = new Scripture(reference3, text3);
        library.AddScripture(scripture3);
        
        Reference reference4 = new Reference("Mosiah", 3, 19);
        string text4 = "For the natural man is an enemy to God, and has been from the dfall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father."+
        "Mosiah 3:19";
        Scripture scripture4 = new Scripture(reference4, text4);
        library.AddScripture(scripture4);
        
        Reference reference5 = new Reference("Galatians", 2, 20);
        string text5 = "Now a mediator is not a mediator of one, but God is one."+
        "Galatians 2:20";
        Scripture scripture5 = new Scripture(reference5, text5);
        library.AddScripture(scripture5);

        Reference reference6 = new Reference("Psalms", 46, 10);
        string text6 = "Be still, and know that I am God: I will be exalted among the heathen, I will be exalted in the earth."+
        "Psalms 46:10";
        Scripture scripture6 = new Scripture(reference6, text6);
        library.AddScripture(scripture6);

        Reference reference7 = new Reference("Philippians", 4, 11, 13);
        string text7 = "Not that I speak in respect of want: for I have learned, in whatsoever state I am, therewith to be content. "+
        "I know both how to be abased, and I know how to abound: every where and in all things I am instructed both to be full and to be hungry, both to bound and to suffer need. "+
        "I can do all things through Christ which strengtheneth me."+
        "Philippians 4:11-13";
        Scripture scripture7 = new Scripture(reference7, text7);
        library.AddScripture(scripture7);

        Reference reference8 = new Reference("Ether", 12, 27);
        string text8 = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."+
        "Ether 12:27";
        Scripture scripture8 = new Scripture(reference8, text8);
        library.AddScripture(scripture8);

        Reference reference9 = new Reference("Moroni", 10, 32);
        string text9 = "Yea, come unto Christ, and be perfected in him, and deny yourselves of all ungodliness; and if ye shall deny yourselves of all ungodliness, and love God with all your might, mind and strength, then is his grace sufficient for you, that by his grace ye may be perfect in Christ; and if by the grace of God ye are perfect in Christ, ye can in nowise deny the power of God."+
        "Moroni 10:32";
        Scripture scripture9 = new Scripture(reference9, text9);
        library.AddScripture(scripture9);

        while (!library.IsEmpty())
        {
            Scripture scripture = library.GetRandomScripture();
            while (!scripture.IsAllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.HiddenText);
                Console.WriteLine("Press Enter to hide a word or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                scripture.HideRandomWord();
            }

            Console.WriteLine("All words are hidden. Moving to the next scripture...");
            library.RemoveScripture(scripture);
        }

        Console.WriteLine("Good Job! You learned all the scriptures.");
    }
}
