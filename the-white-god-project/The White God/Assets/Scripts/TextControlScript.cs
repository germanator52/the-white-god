using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControlScript : MonoBehaviour {

    public static TextControlScript instance;

    int modifier;
    int iteration = 1;

    public Text text;

    public GameObject policeCanvas;
    public GameObject townHallFlyerCanvas;
    public GameObject dorisCanvas;
    public GameObject officeCanvas;
    public GameObject officeCanvas2;
    public GameObject convenienceStoreFlyerCanvas;
    public GameObject bibleCanvas;

    void Start()
    {
        instance = this;
    }

    void Update()
    {
        if (Input.GetKeyDown("return"))
        {
            if (modifier == 1)
            {
                PoliceLetter();
            } else if (modifier == 2)
            {
                PoliceList();
            } else if (modifier == 3)
            {
                ChurchFlyer();
            } else if (modifier == 4)
            {
                MayoralRace();
            } else if (modifier == 5)
            {
                WantedPoster();
            } else if (modifier == 6)
            {
                Notice();
            } else if (modifier == 8)
            {
                DorisNote();
            } else if (modifier == 9)
            {
                Binder();
            } else if (modifier == 10)
            {
                Pages();
            } else if (modifier == 11)
            {
                Journal();
            } else if (modifier == 12)
            {
                ChurchFlyer2();
            } else if (modifier == 13)
            {
                MayoralRace2();
            } else if (modifier == 14)
            {
                WantedPoster2();
            } else if (modifier == 15)
            {
                CurfewNotice();
            } else if (modifier == 16)
            {
                ObjectColliderScript.instance.Unpause(0);
            } else if (modifier == 18)
            {
                BiblePassage();
            }
        }
    }

    public void ChangeText(int i)
    {
        if (i == 1)
        {
            text.text = "Sheriff Underwood,";
            policeCanvas.SetActive(false);
        }
        else if (i == 2)
        {
            text.text = "Arrest log - 4/30 - 5/13";
            policeCanvas.SetActive(false);
        }
        else if (i == 3)
        {
            text.text = "A picture of a church's sanctuary and a group of middle-aged people with warm, inviting smiles adorns this flyer.";
            townHallFlyerCanvas.SetActive(false);
        }
        else if (i == 4)
        {
            text.text = "It seemed that before, Avonfield had been in the middle of a mayoral election.";
            townHallFlyerCanvas.SetActive(false);
        }
        else if (i == 5)
        {
            text.text = "A single wanted poster joins the rest of the flyers.";
            townHallFlyerCanvas.SetActive(false);
        }
        else if (i == 6)
        {
            text.text = "This flyer is a simple white sheet of paper with a strange symbol of an eye.";
            townHallFlyerCanvas.SetActive(false);
        }
        else if (i == 7)
        {
            text.text = "There's a piece of paper under the desk.  Will you read it?";
            dorisCanvas.SetActive(true);
        }
        else if (i == 8)
        {
            text.text = "5/7";
            dorisCanvas.SetActive(false);
        } else if (i == 9) {
            text.text = "(The binder contains logs of the motel's various guests over time.)";
            officeCanvas.SetActive(false);
        } else if (i == 10)
        {
            text.text = "Terry,";
            officeCanvas.SetActive(false);
        } else if (i == 11)
        {
            text.text = "5/5";
            officeCanvas2.SetActive(false);
        } else if (i == 12)
        {
            text.text = "A picture of a church's sanctuary and a group of middle-aged people with warm, inviting smiles adorns this flyer.";
            convenienceStoreFlyerCanvas.SetActive(false);
        } else if (i == 13)
        {
            text.text = "It seemed that before, Avonfield had been in the middle of a mayoral election.";
            convenienceStoreFlyerCanvas.SetActive(false);
        } else if (i == 14)
        {
            text.text = "A single wanted poster joins the rest of the flyers.";
            convenienceStoreFlyerCanvas.SetActive(false);
        } else if (i == 15)
        {
            text.text = "This flyer has no attached picture. It is simply a message written in large text.";
            convenienceStoreFlyerCanvas.SetActive(false);
        } else if (i == 16)
        {
            text.text = "You notice an engraving on the bottom frame of the number 33.";
        } else if (i == 17)
        {
            text.text = "The Bible is open to a specific page, and a specific passage is marked.  Will you read it?";
            bibleCanvas.SetActive(true);
        } else if (i == 18)
        {
            text.text = "You feel a strange urge to read it out loud and do so.";
            bibleCanvas.SetActive(false);
        }
        modifier = i;
        iteration = 1;
    }

    void PoliceLetter()
    {
        if (iteration == 8)
        {
            text.text = "Sincerely, Pastor McKinley";
            policeCanvas.SetActive(true);
        }
        else if (iteration == 7)
        {
            text.text = "Deal with her.";
        }
        else if (iteration == 6)
        {
            text.text = "Another thing - the agent that's been frequenting our church in the past few weeks is becoming more than a nuisance.";
        }
        else if (iteration == 5)
        {
            text.text = "Make sure that anybody you spare leaves this town with no impressions whatsoever.";
        }
        else if (iteration == 4)
        {
            text.text = "You've done a fantastic job of striking a balance between taking and sparing when it comes to outsiders, and I urge you to keep that up.";
        }
        else if (iteration == 3)
        {
            text.text = "As hospitable as our town may seem, we cannot afford to open our gates further.";
        }
        else if (iteration == 2)
        {
            text.text = "I'm not sure exactly what the reason for this development is - it is most likely a coincidence - but I trust you will handle it accordingly.";
        }
        else if (iteration == 1)
        {
            text.text = "The Parishioners have given me reports of an above average number of outsiders passing through Avonfield as of late.";
        }
        iteration++;
    }

    void PoliceList()
    {
        if (iteration == 7)
        {
            text.text = "Doris Anderson - 24 - Heretic";
            policeCanvas.SetActive(true);
        }
        else if(iteration == 6)
        {
            text.text = "Phillip Curry - 30 - Outsider";
        }
        else if(iteration == 5)
        {
            text.text = "Yvonne Townsend - 20 - Delinquint";
        }
        else if (iteration == 4)
        {
            text.text = "Percy Alvarez - 29 - Dissenter";
        }
        else if (iteration == 3)
        {
            text.text = "George Jones - 43 - Outsider";
        }
        else if (iteration == 2)
        {
            text.text = "Tanya Bishop - 28 - Outsider";
        }
        else if (iteration == 1)
        {
            text.text = "Clayton Robertson - 34 - Outsider";
        }
        iteration++;
    }

    void ChurchFlyer()
    {
        if (iteration == 4)
        {
            text.text = "Avonfield Church!  Join our lovely world today!";
            townHallFlyerCanvas.SetActive(true);
        } else if (iteration == 3)
        {
            text.text = "Below the picture is a caption:";
        } else if (iteration == 2)
        {
            text.text = "Looking at him stirrs something in your mind, but before you can grab hold of it, it's gone.";
        } else if (iteration == 1)
        {
            text.text = "In the middle of them is a tall man who looked to be in his fifties, with short, well kept hair and a formal blue suit.";
        }
        iteration++;
    }

    void MayoralRace()
    {
        if (iteration == 4)
        {
            text.text = "Re - elect Joshua McKinley as Avonfield mayor!";
            townHallFlyerCanvas.SetActive(true);
        } else if (iteration == 3)
        {
            text.text = "A photo of a middle-aged man with short, tidy grey hair and a formal blue suit was plastered all over the wall, with a caption reading:";
        } else if (iteration == 2)
        {
            text.text = "In either case, as far as you could tell, there only seemed to be a single candidate.";
        } else if (iteration == 1)
        {
            text.text = "Or, perhaps, it had just finished one.";
        }
        iteration++;
    }

    void WantedPoster()
    {
        if (iteration == 2)
        {
            text.text = "Wanted: Percy Alvarez.  Deviant and Dissenter";
            townHallFlyerCanvas.SetActive(true);
        } else if (iteration == 1)
        {
            text.text = "It shows a photo of a young man with a caption beneath.";
        }
        iteration++;
    }

    void Notice()
    {
        if (iteration == 3)
        {
            text.text = "DISSENTERS WILL NOT BE TOLERATED";
            townHallFlyerCanvas.SetActive(true);
        } else if (iteration == 2)
        {
            text.text = "Beneath it was a simple caption in large type:";
        } else if (iteration == 1)
        {
            text.text = "It seemed to give off an ominous vibe, similar to the presence that seemed to be emanating from the church.";
        }
        iteration++;
    }

    void DorisNote()
    {
        if (iteration == 1)
        {
            text.text = "I have to get out of here.";
        } else if (iteration == 2)
        {
            text.text = "I've seen too much, and they know it.  McKinley labeled me a heretic, and if he hasn't declared that publicly already than he will soon.";
        } else if (iteration == 3)
        {
            text.text = "I'm not sure if there'll be a lynch mob or if they'll take me away quietly, but they'll be coming soon one way or another.";
        } else if (iteration == 4)
        {
            text.text = "Something terrible is happening here, and after the past night I finally understand what it is.";
        } else if (iteration == 5)
        {
            text.text = "It's worse than I ever could have imagined...  It needs to be stopped.";
        } else if (iteration == 6)
        {
            text.text = "I'm returning back to headquarters as soon as I can, and when I get back, I'll put a stop to all of this, once and for all.";
        } else if (iteration == 7)
        {
            text.text = "In the meantime, I'll try and hide this note in here, in case I don't make it out.";
        } else if (iteration == 8)
        {
            text.text = "They'll probably";
        } else if (iteration == 9)
        {
            text.text = "(The text cuts off there; it seems the journal entry will remain forever unfinished.)";
        } else if (iteration == 10)
        {
            ObjectColliderScript.instance.Unpause(3);
        }
        iteration++;
    }

    void Binder()
    {
        if (iteration == 1)
        {
            text.text = "(You turn to the most recent page, and take a glance at it.)";
        }
        else if (iteration == 2)
        {
            text.text = "5/9";
        }
        else if (iteration == 3)
        {
            text.text = "Room 01 - Clayton Robertson (this name has been crossed out)";
        }
        else if (iteration == 4)
        {
            text.text = "Room 02 - Arthur and Bessie Weavers";
        }
        else if (iteration == 5)
        {
            text.text = "Room 03 - April Horner & Diane Ferguson";
        }
        else if (iteration == 6)
        {
            text.text = "Room 04 - George Jones (this name has been crossed out)";
        }
        else if (iteration == 7)
        {
            text.text = "Room 05 - Phillip Curry (this name has been crossed out)";
        }
        else if (iteration == 8)
        {
            text.text = "Room 06 - Doris Anderson (this name has been crossed out)";
        }
        else if (iteration == 9)
        {
            text.text = "Room 07 - Walter Gipson";
        } else if (iteration == 10)
        {
            text.text = "Room 08 - vacant";
        } else if (iteration == 11)
        {
            text.text = "Room 09 - Tanya Bishop (this name has been crossed out)";
        } else if (iteration == 12)
        {
            text.text = "Room 10 - Janice Carter (this name has a star and the date 5/12 written next to it)";
        } else if (iteration == 13)
        {
            officeCanvas.SetActive(true);
        }
        iteration++;
    }

    void Pages()
    {
        if (iteration == 1)
        {
            text.text = "We finally caught up with Percy and he has been dealt with.";
        } else if (iteration == 2)
        {
            text.text = "The case has been closed and as such the evidence is no longer confidential.";
        } else if (iteration == 3)
        {
            text.text = "These journals were found in his house.";
        } else if (iteration == 4)
        {
            text.text = "I know you valued him as an employee, but you must understand that dissenters cannot be tolerated.";
        } else if (iteration == 5)
        {
            text.text = "(There's another piece of paper beneath it.  Will you read it?)";
            officeCanvas2.SetActive(true);
        }
        iteration++;
    }

    void Journal()
    {
        if (iteration == 1)
        {
            text.text = "I think they're onto me.";
        } else if (iteration == 2)
        {
            text.text = "The others have hidden their tracks well, and I don't think they'll be caught just yet, but I need to leave town.";
        } else if (iteration == 3)
        {
            text.text = "We still don't know what happens to the dissenters that are caught - only that they're never seen or heard from again.";
        } else if (iteration == 4)
        {
            text.text = "I don't wish to become one of those cold cases.";
        } else if (iteration == 5)
        {
            text.text = "I'm leaving town tonight.";
        } else if (iteration == 6)
        {
            text.text = "My god, what happened to this place?";
        } else if (iteration == 7)
        {
            text.text = "For all its faults it used to be such a nice town.";
        } else if (iteration == 8)
        {
            text.text = "For all its faults it used to be such a nice town.";
        } else if (iteration == 9)
        {
            text.text = "I saw this coming; we all did.";
        } else if (iteration == 10)
        {
            text.text = "I tried to speak out at first, but they told me I had been brainwashed by the university.";
        } else if (iteration == 11)
        {
            text.text = "Now they're all just puppets of a mad man and his White God.";
        } else if (iteration == 12)
        {
            text.text = "Goodbye Avonfield.  I can't save you.";
        } else if (iteration == 13)
        {
            text.text = "I'm not sure anyone can.";
            officeCanvas.SetActive(true);
        }
        iteration++;
    }

    void ChurchFlyer2()
    {
        if (iteration == 4)
        {
            text.text = "Avonfield Church!  Join our lovely world today!";
            convenienceStoreFlyerCanvas.SetActive(true);
        }
        else if (iteration == 3)
        {
            text.text = "Below the picture is a caption:";
        }
        else if (iteration == 2)
        {
            text.text = "Looking at him stirrs something in your mind, but before you can grab hold of it, it's gone.";
        }
        else if (iteration == 1)
        {
            text.text = "In the middle of them is a tall man who looked to be in his fifties, with short, well kept hair and a formal blue suit.";
        }
        iteration++;
    }

    void MayoralRace2()
    {
        if (iteration == 4)
        {
            text.text = "Re - elect Joshua McKinley as Avonfield mayor!";
            convenienceStoreFlyerCanvas.SetActive(true);
        }
        else if (iteration == 3)
        {
            text.text = "A photo of a middle-aged man with short, tidy grey hair and a formal blue suit was plastered all over the wall, with a caption reading:";
        }
        else if (iteration == 2)
        {
            text.text = "In either case, as far as you could tell, there only seemed to be a single candidate.";
        }
        else if (iteration == 1)
        {
            text.text = "Or, perhaps, it had just finished one.";
        }
        iteration++;
    }

    void WantedPoster2()
    {
        if (iteration == 2)
        {
            text.text = "Wanted: Percy Alvarez.  Deviant and Dissenter";
            convenienceStoreFlyerCanvas.SetActive(true);
        }
        else if (iteration == 1)
        {
            text.text = "It shows a photo of a young man with a caption beneath.";
        }
        iteration++;
    }

    void CurfewNotice()
    {
        if (iteration == 1)
        {
            text.text = "Remember the Curfew!";
        } else if (iteration == 2)
        {
            text.text = "Anyone caught outside after 9:00 PM will be arrested or fined!";
        } else if (iteration == 3)
        {
            text.text = "Minors will be escorted home and their parents will be issued a warning!";
        } else if (iteration == 4)
        {
            text.text = "NO EXCEPTIONS!";
            convenienceStoreFlyerCanvas.SetActive(true);
        }
        iteration++;
    }

    void BiblePassage()
    {
        if (iteration == 1)
        {
            text.text = "Again the devil took him to a very high mountain and showed him all the kingdoms of the world and their splendor.";
        } else if (iteration == 2)
        {
            text.text = "You hear a strange, light clicking sound.";
        } else if (iteration == 3)
        {
            text.text = "A small compartment has opened near the top of the podium.  What looks like a two digit combination lock is inside.";
        } else if (iteration == 4)
        {
            ObjectColliderScript.instance.Unpause(0);
        }
        iteration++;
    }
}
