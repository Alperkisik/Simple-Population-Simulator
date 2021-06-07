using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace popülasyon
{
    class Program
    {
        static string ch = "";
        static List<Human> population = new List<Human>();
        static Random rnd = new Random();
        static List<string> MaleNames = new List<string>();
        static List<string> FemaleNames = new List<string>();
        static List<string> FamilyNames = new List<string>();
        static Human person;
        static void Main(string[] args)
        {   
            bool var = false;

            #region atama
            MaleNames.Add("Jessi"); MaleNames.Add("Alper"); MaleNames.Add("John");
            MaleNames.Add("Thorgrim"); MaleNames.Add("Karl"); MaleNames.Add("Kazakhi");
            MaleNames.Add("Elton"); MaleNames.Add("Jack"); MaleNames.Add("Don");
            MaleNames.Add("Axl"); MaleNames.Add("Louie"); MaleNames.Add("Jamison");
            MaleNames.Add("Alp"); MaleNames.Add("Louen"); MaleNames.Add("Gabriel");
            MaleNames.Add("Frodo"); MaleNames.Add("Tyrion"); MaleNames.Add("Gerard");
            MaleNames.Add("Elrond"); MaleNames.Add("Teclis"); MaleNames.Add("Hans");
            MaleNames.Add("Chandler"); MaleNames.Add("Ross"); MaleNames.Add("Joey");
            MaleNames.Add("Marty"); MaleNames.Add("Emmond"); FemaleNames.Add("Kaan");
            FemaleNames.Add("Mertcan"); FemaleNames.Add("Jim"); FemaleNames.Add("John");
            FemaleNames.Add("Alexi"); FamilyNames.Add("Nick"); FamilyNames.Add("Mert");

            FemaleNames.Add("Molly"); FemaleNames.Add("Eva"); FemaleNames.Add("Duru");
            FemaleNames.Add("Yıldız"); FemaleNames.Add("Elsie"); FemaleNames.Add("Clara");
            FemaleNames.Add("Asuna"); FemaleNames.Add("Yeşim"); FemaleNames.Add("Deniz");
            FemaleNames.Add("Johanna"); FemaleNames.Add("Azuki"); FemaleNames.Add("Maya");
            FemaleNames.Add("Eowin"); FemaleNames.Add("Ana"); FemaleNames.Add("Brigitte");
            FemaleNames.Add("Khalida"); FemaleNames.Add("Madison"); FemaleNames.Add("Hana");
            FemaleNames.Add("Dolores"); FemaleNames.Add("Scarlet"); FemaleNames.Add("Arwen");
            FemaleNames.Add("Monica"); FemaleNames.Add("Rachel"); FemaleNames.Add("Pheobe");
            FemaleNames.Add("Jenifer"); FemaleNames.Add("Johanna"); FemaleNames.Add("Melek");
            FemaleNames.Add("Şeyma"); FemaleNames.Add("Sude"); FemaleNames.Add("Yalen");
            FemaleNames.Add("Red"); FemaleNames.Add("Halen"); FemaleNames.Add("Tracer");

            FamilyNames.Add("Ravenclaw"); FamilyNames.Add("Wei"); FamilyNames.Add("Ravenhide");
            FamilyNames.Add("Tribiani"); FamilyNames.Add("Geller"); FamilyNames.Add("Bing");
            FamilyNames.Add("Buffay"); FamilyNames.Add("Green"); FamilyNames.Add("Morison");
            FamilyNames.Add("Reyes"); FamilyNames.Add("Bilge"); FamilyNames.Add("Amari");
            FamilyNames.Add("Woodbreaker"); FamilyNames.Add("Şanslı"); FamilyNames.Add("Roque");
            FamilyNames.Add("Ironfist"); FamilyNames.Add("Balboa"); FamilyNames.Add("Rose");
            FamilyNames.Add("Gamgee"); FamilyNames.Add("Baggins"); FamilyNames.Add("Winston");
            FamilyNames.Add("Took"); FamilyNames.Add("Wisehand"); FamilyNames.Add("Kalkan");
            FamilyNames.Add("Rolingstones"); FamilyNames.Add("Beatles"); FamilyNames.Add("Mcfly");
            FamilyNames.Add("Brown"); FamilyNames.Add("Gagalı"); FamilyNames.Add("Silent");
            FamilyNames.Add("Proudhand"); FamilyNames.Add("Parrot"); FamilyNames.Add("Fox");
            FamilyNames.Add("McCree"); FamilyNames.Add("Lovegood"); FamilyNames.Add("Potter");
            FamilyNames.Add("Grincer"); FamilyNames.Add("Wizzly");
            #endregion

            int value;
            for (int i = 0; i < FamilyNames.Count; i++)
            {
                person = new Human();
                person.age = rnd.Next(20,35);
                value = rnd.Next(0,2);
                if(value == 0)
                {
                    person.gender = "Male";
                    value = rnd.Next(0,MaleNames.Count);
                    person.name = MaleNames[value];
                }
                else if(value == 1)
                {
                    person.gender = "Female";
                    value = rnd.Next(0, FemaleNames.Count);
                    person.name = FemaleNames[value];
                }

                if (i == 0)
                {
                    value = rnd.Next(0, FamilyNames.Count);
                    person.surName = FamilyNames[value];
                }
                else
                {
                    do
                    {
                        value = rnd.Next(0, FamilyNames.Count);
                        var = false;
                        foreach (Human h in population)
                        {
                            if (h.surName == FamilyNames[value])
                            {
                                var = true;
                                break;
                            }
                        }
                    } while (var);
                    person.surName=FamilyNames[value];
                }

                person.state = "Single";
                population.Add(person);
            }
            
            int count = 1;
            foreach (Human h in population)
            {
                Console.WriteLine( count + ". person " + h.name + " " + h.surName + " Age=" + h.age + " Gender="+h.gender + " State="+h.state);
                count++;
            }
            
            Thread th1 = new Thread(new ThreadStart(Control));
            Thread th2 = new Thread(new ThreadStart(program));
            th1.Start();
            th2.Start();
        }

        private static void Control()
        {
            ch = Console.ReadKey().ToString();
        }

        static List<Human> Dead = new List<Human>();
        static List<Human> Graveyard = new List<Human>();
        static int numberOfEvents;
        private static void program()
        {
            List<string> Events = new List<string>();

            #region 10luk atama
            //Marriage %50, dead %10 , Born with marriage %30 , Born without Marriage %10
            Events.Add("Marriage"); Events.Add("Marriage"); Events.Add("Marriage"); Events.Add("Marriage"); Events.Add("Marriage");
            Events.Add("Dead"); Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage"); Events.Add("BornWithoutMarriage");
            #endregion

            #region 100lük atama
            /*Events.Add("Marriage"); Events.Add("Marriage"); Events.Add("BornWithMarriage"); Events.Add("BornWithoutMarriage");
            Events.Add("BornWithoutMarriage"); Events.Add("BornWithoutMarriage"); Events.Add("BornWithoutMarriage");
            Events.Add("Marriage"); Events.Add("Marriage"); Events.Add("BornWithMarriage"); Events.Add("Marriage");
            Events.Add("Marriage"); Events.Add("Marriage"); Events.Add("Dead"); Events.Add("BornWithMarriage");
            Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage"); Events.Add("Marriage"); Events.Add("Marriage");
            Events.Add("Marriage"); Events.Add("Marriage"); Events.Add("BornWithoutMarriage"); Events.Add("BornWithoutMarriage");
            Events.Add("BornWithMarriage"); Events.Add("Marriage"); Events.Add("Marriage"); Events.Add("Dead"); Events.Add("Dead");
            Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage"); Events.Add("Marriage");
            Events.Add("Marriage"); Events.Add("Marriage"); Events.Add("Marriage"); Events.Add("Marriage"); Events.Add("Marriage");
            Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage"); Events.Add("Marriage");
            Events.Add("Marriage"); Events.Add("Marriage"); Events.Add("Marriage"); Events.Add("Marriage"); Events.Add("BornWithMarriage");
            Events.Add("BornWithoutMarriage"); Events.Add("BornWithoutMarriage"); Events.Add("Marriage"); Events.Add("Marriage"); Events.Add("Marriage");
            Events.Add("Marriage"); Events.Add("Marriage"); Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage");
            Events.Add("BornWithMarriage"); Events.Add("Marriage"); Events.Add("Marriage"); Events.Add("Dead"); Events.Add("Marriage");
            Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage"); Events.Add("Dead"); Events.Add("BornWithoutMarriage");
            Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage"); Events.Add("Dead"); Events.Add("BornWithoutMarriage");
            Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage"); Events.Add("Dead"); Events.Add("BornWithoutMarriage");
            Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage"); Events.Add("Dead"); Events.Add("BornWithoutMarriage");
            Events.Add("Dead"); Events.Add("BornWithMarriage"); Events.Add("Dead"); Events.Add("BornWithoutMarriage");
            Events.Add("Marriage"); Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage");
            Events.Add("Marriage"); Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage");
            Events.Add("Marriage"); Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage");
            Events.Add("Marriage"); Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage");
            Events.Add("Marriage"); Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage"); Events.Add("BornWithMarriage");*/
            #endregion

            string action;
            int year = 1;
            int luck;
            int male = 0, female = 0;
            bool checkMale = false, checkFemale = false;
            while (ch == "")
            {
                numberOfEvents = rnd.Next(1, (2 + year));
                Console.WriteLine("_____________________________YEAR "+year+"_____________________________________________");
                int men = 0, women = 0, m= 0,s=0,YasOrtalamasi=0,old=0;
                for (int i = 0; i < population.Count; i++)
                {
                    YasOrtalamasi += population[i].age;
                    if (population[i].age >= 85)
                        old++;
                    if (population[i].gender == "Female")
                        women++;
                    else
                        men++;

                    if (population[i].state == "Marriaged")
                        m++;
                    else
                        s++;
                }
                YasOrtalamasi /= population.Count;
                Console.WriteLine("Population=" + population.Count + " Men=" + men + " Women=" + women + " Marriage="+m +" Single="+s + " Number of Events=" + numberOfEvents + " Age Average=" + YasOrtalamasi + " old(over90)=" +old );

                Thread.Sleep(1000);
                year++;
                foreach (Human h in population)
                {
                    if(h.age > 75 && h.age < 85)
                    {
                        luck = rnd.Next(0,100);
                        if (luck < 5)
                        {
                            Dead.Add(h);
                        }
                        else
                            h.age++;
                    }
                    else if(h.age >= 85 && h.age < 95)
                    {
                        luck = rnd.Next(0, 101);
                        if (luck < 15)
                        {
                            Dead.Add(h);
                        }
                        else
                            h.age++;
                    }
                    else if(h.age >= 95)
                    {
                        luck = rnd.Next(0, 101);
                        if (luck < 51)
                        {
                            Dead.Add(h);
                        }
                        else
                            h.age++;
                    }
                    else
                        h.age++;
                }
                kill();
                
                for (int h = 0; h < numberOfEvents; h++)
                {
                    luck = rnd.Next(0, Events.Count);
                    action = Events[luck];

                    if (action == "Dead")
                    {
                        luck = rnd.Next(0, population.Count);
                        personControl(population[luck]);
                        population.Remove(population[luck]);
                    }
                    else if (action == "Marriage")
                    {
                        bool singleMan = false, singleWoman = false;
                        for (int i = 0; i < population.Count; i++)
                        {
                            if (population[i].gender == "Male" && population[i].state == "Single" && population[i].age > 18)
                                singleMan = true;
                            else if (population[i].gender == "Female" && population[i].state == "Single" && population[i].age > 18)
                                singleWoman = true;
                        }

                        if (singleMan && singleWoman)
                        {
                            checkMale = false; checkFemale = false;
                            male = 0; female = 0;
                            do
                            {
                                luck = rnd.Next(0, population.Count);
                                checkMale = false;
                                if (population[luck].state == "Single" && population[luck].age > 18 && population[luck].gender == "Male")
                                {
                                    checkMale = true;
                                    male = luck;
                                }
                            } while (!checkMale);

                            do
                            {
                                luck = rnd.Next(0, population.Count);
                                checkFemale = false;
                                if (population[luck].state == "Single" && population[luck].age > 18 && population[luck].gender == "Female")
                                {
                                    checkFemale = true;
                                    female = luck;
                                }
                            } while (!checkFemale);

                            population[male].state = "Marriaged"; population[male].marriage = population[female];
                            population[female].state = "Marriaged"; population[female].marriage = population[male];
                            population[female].surName = population[male].surName;
                        }
                    }
                    else if (action == "BornWithoutMarriage")
                    {
                        male = 0; female = 0;
                        checkMale = false; checkFemale = false;
                        do
                        {
                            luck = rnd.Next(0, population.Count);
                            checkMale = false;
                            if (population[luck].age > 15 && population[luck].gender == "Male")
                            {
                                checkMale = true;
                                male = luck;
                            }
                        } while (!checkMale);

                        do
                        {
                            luck = rnd.Next(0, population.Count);
                            checkFemale = false;
                            if (population[luck].age > 15 && population[luck].gender == "Female")
                            {
                                checkFemale = true;
                                female = luck;
                            }
                        } while (!checkFemale);

                        generateHuman(population[female], population[male]);
                    }
                    else if (action == "BornWithMarriage")
                    {
                        bool found = false, var = false;

                        for (int i = 0; i < population.Count; i++)
                        {
                            if (population[i].state == "Marriaged")
                                var = true;
                        }

                        if (var)
                        {
                            do
                            {
                                luck = rnd.Next(0, population.Count);
                                found = false;
                                if (population[luck].state == "Marriaged")
                                {
                                    found = true;
                                }
                            } while (!found);

                            if (population[luck].gender == "Female")
                                generateHuman(population[luck], population[luck].marriage);
                            else if (population[luck].gender == "Male")
                                generateHuman(population[luck].marriage, population[luck]);
                        }
                    }
                }
                
            }

            char choice = ' ';
            switch(choice)
            {
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }

        static void kill()
        {
            foreach (Human h in Dead)
            {
                personControl(h);
                Graveyard.Add(h);
                population.Remove(h);
            }
            Dead.Clear();
        }

        static void personControl(Human p)
        {
            foreach (Human lifepartner in population)
            {
                if(lifepartner.marriage == p)
                {
                    lifepartner.state = "Single";
                    lifepartner.marriage = null;
                }
            }
        }

        static void generateHuman(Human mother,Human Father)
        {
            person = new Human();
            int gender = rnd.Next(0, 2);
            person.age = 0;
            person.surName = Father.surName;
            person.father = Father;
            person.mother = mother;
            if(gender==0)
            {
                person.gender = "Male";
                person.name = MaleNames[rnd.Next(0,MaleNames.Count)];
            }
            else if(gender == 1)
            {
                person.gender = "Female";
                person.name = FemaleNames[rnd.Next(0, FemaleNames.Count)];
            }
            person.state = "Single";

            population.Add(person);
        }
    }
}
