using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GameStoreApi.Controllers
{
    [ApiController]
    [Route("api/games")]
    public class GamesController : ControllerBase
    {
        // Your existing Game class and games list

        // Define a new method to return the JSON data
        [HttpGet("story")]
        public IActionResult GetStory()
        {
            var storyData = new Dictionary<string, object>
            {
                ["start"] = new Dictionary<string, object>
                {
                    ["text"] = "In the year 2188, humanity's survival hinged on cosmic exploration as Earth's resources dwindled. You embarked on a critical mission, seeking the vanished Dr. Emily Walker on the enigmatic planet Dagon-4B. <br><br>Guided by stories of this uncharted world—lush, diverse, and veiled in mystery—your spacecraft descended amidst a blizzard. The tumultuous storm obscured the terrain as you touched down on Dagon-4B's alien soil. <br><br>Stepping out, the frigid air carried unknown scents. Through the swirling snow, hints of vibrant landscapes teased your senses, promising a captivating yet concealed world. <br><br>The blizzard's embrace whispered of thrilling discoveries and hidden dangers, setting the stage for your odyssey into the uncharted depths of Everlost. <br><br>Start Game? <br><br>YES / NO",
                    ["image"] = "images/start.jpg",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["yes"] = "firstScene",
                        ["no"] = null
                    }
                },
                ["firstScene"] = new Dictionary<string, object>
                {
                    ["text"] = "_name_, You land in the midst of a raging blizzard, the icy winds whip around you as you struggle to make a critical decision. Do you seek refuge in the mysterious depths of a cave, hoping for safety within its darkness? Or do you bravely forge ahead, determined to face the unknown dangers lurking in the relentless storm? <br><br>CAVE / PROCEED",
                    ["image"] = "images/firstScene.jpg",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["cave"] = "caveEntrance",
                        ["proceed"] = "frozenForrestEntrance"
                    }
                },
                ["caveEntrance"] = new Dictionary<string, object>
                {
                    ["text"] = "As you step into the cave's chilling embrace, the faint glimmer of your torch reveals two diverging paths ahead. Will you choose the left passage, shrouded in shadow and mystery? Or does the right path, bathed in a dim light hinting at possible discoveries, beckon you forward? <br><br>LEFT / RIGHT",
                    ["image"] = "images/caveEntrance.jpg",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["left"] = "caveScene1",
                        ["right"] = "caveScene2"
                    }
                },
                ["caveScene1"] = new Dictionary<string, object>
                {
                    ["text"] = "In the heart of the cavern's obsidian embrace, you face two treacherous choices. Will you risk traversing the precarious ledge, its edges vanishing into the abyssal darkness? Or does the ominous and perilous prospect of squeezing through a narrow gap, cocooned in thick, sticky spider webs that obscure your view, deter you, warning of potential entanglement and the lurking presence of the unseen. <br><br>LEDGE / GAP",
                    ["image"] = "images/caveScene1.jpg",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["ledge"] = "ledgeDeath",
                        ["gap"] = "caveExitScene1"
                    }
                },
                ["caveScene2"] = new Dictionary<string, object>
                {
                    ["text"] = "As you press onward, the passage abruptly terminates, revealing two branching paths illuminated by faint glimmers of light. Ahead lies a water-filled passage, its depths hinting at a potential aquatic route. Above, a gap reveals a tantalizing beam of light, yet the ascent promises an uncertain climb through unknown perils. Do you dare to plunge into the murky waters, risking what may lurk beneath? Or will you brave the climb, ascending toward the light? <br><br>PASSAGE / CLIMB",
                    ["image"] = "images/caveScene2.jpg",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["passage"] = "caveExitScene2",
                        ["climb"] = "fallDeath"
                    }
                },
                ["fallDeath"] = new Dictionary<string, object>
                {
                    ["text"] = "You desperately claw at the rocks, but your grip fails, and you plummet into the yawning abyss below, a piercing scream tearing through the cavern's eerie silence. The echoes of your desperate cries fade into the darkness. Your journey ends abruptly. Game Over. <br><br>Would you like to play again? <br><br>YES / NO",
                    ["image"] = "images/fallDeath.jpg",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["yes"] = "start",
                        ["no"] = null
                    }
                },
                ["ledgeDeath"] = new Dictionary<string, object>
                {
                    ["text"] = "The ledge crumbles beneath your weight, and with a chilling scream, you plummet into the gaping abyss below. The sound of your panicked cries echoes through the cavern, but the darkness swallows them whole. Your journey meets a sudden, tragic end. Game Over. <br><br>Would you like to play again? <br><br>YES / NO",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["yes"] = "start",
                        ["no"] = null
                    }
                },
                ["caveExitScene1"] = new Dictionary<string, object>
                {
                    ["text"] = "As you painstakingly navigate the tight gap, emerging from the webbed passage that leads to the cave's exit, the relentless blizzard greets you with heightened ferocity. Outside, the winds lash out with a renewed fury, threatening to strip away any semblance of warmth. Do you hasten to construct a shelter, seeking refuge from the storm's worsening assault? Or do you contemplate the necessity of building a fire, craving the warmth to stave off the bone-chilling cold closing in on you? <br><br>SHELTER / FIRE",
                    ["image"] = "images/caveExit.jpg",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["shelter"] = "shelterScene",
                        ["fire"] = "fireDeathScene1"
                    }
                },
                ["caveExitScene2"] = new Dictionary<string, object>
                {
                    ["text"] = "As you brave the chilling waters, traversing through the water-filled passage and emerging into an opening guiding you to the cave's exit, time elapses amid the numbing cold. Stepping outside, the blizzard's fury magnifies, each icy gust relentless and unforgiving. Will you urgently construct a shelter, racing against the storm's escalating hostility? Or do you swiftly contemplate building a fire, recognizing the pressing need to ward off the encroaching frostbite threatening to consume you? <br><br>SHELTER / FIRE",
                    ["image"] = "images/caveExit.jpg",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["shelter"] = "shelterScene",
                        ["fire"] = "fireDeathScene2"
                    }
                },
                ["fireDeathScene1"] = new Dictionary<string, object>
                {
                    ["text"] = "As the flames from your fire flicker and dance, casting a faint warmth amidst the freezing winds, an ominous presence lurks in the shadows. The crackling firelight becomes a beacon, drawing forth a savage creature from the darkness. In a sudden, horrifying onslaught, the creature pounces, its savage assault tearing through you mercilessly. Game Over. <br><br>Would you like to play again? <br><br>YES / NO",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["yes"] = "start",
                        ["no"] = null
                    }
                },
                ["fireDeathScene2"] = new Dictionary<string, object>
                {
                    ["text"] = "As you strive to kindle a fire to dry off from the chilling waters, the relentless howling winds thwart your attempts. Despite your efforts, the unforgiving elements prevent the fire from taking hold, and you succumb to the bitter cold. Game Over. <br><br>Would you like to play again? <br><br>YES / NO",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["yes"] = "start",
                        ["no"] = null
                    }
                },
                ["frozenForrestEntrance"] = new Dictionary<string, object>
                {
                    ["text"] = "Pressing onward, your footing betrays you, and you stumble uncontrollably down a steep, treacherous slope. As you reach the bottom, shaken but resilient, you find yourself standing at the entrance of a frozen forest. Two pathways lie before you: one extends straight ahead, while the other veers to the left. Which path shall you embark upon in this enigmatic woodland? <br><br>STRAIGHT / LEFT",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["straight"] = "frozenForrestScene",
                        ["left"] = "torchScene"
                    }
                },
                ["frozenForrestScene"] = new Dictionary<string, object>
                {
                    ["text"] = "As you arrive at a serene clearing adorned by a vast frozen lake, a crucial decision looms ahead. Will you opt for the swifter yet riskier journey across the icy expanse? Or do you choose the cautious path, navigating around the perimeter to ensure a safer passage? <br><br>CROSS / GO AROUND",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["cross"] = "lakeScene",
                        ["go around"] = "delayScene" // note: 'go_around' used due to space in the option key
                    }
                },
                ["torchScene"] = new Dictionary<string, object>
                {
                    ["text"] = "Venturing leftward into the heart of the forest, dusk begins to cast its shadowy veil. Realizing your torch has been lost during the earlier fall, a dilemma unfolds. Do you choose to retrace your steps, risking further delay to retrieve the torch? Or do you bravely press forward into the deepening darkness, relying solely on your instincts to guide your path? <br><br>GO BACK / PROCEED",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["go back"] = "searchScene", // note: 'go_back' used due to space in the option key
                        ["proceed"] = "crevasseScene"
                    }
                },
                ["searchScene"] = new Dictionary<string, object>
                {
                    ["text"] = "Retracing your steps, you stumble back and rediscover your torch, its light offering a glimmer of hope amidst the worsening storm. The tempest has intensified during your absence. Will you persevere, braving the escalating fury of the storm? Or do you opt to seek refuge, hastily constructing a shelter to shield yourself from the relentless onslaught of the alien storm? <br><br>PROCEED / SHELTER",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["proceed"] = "cliffDeathScene",
                        ["shelter"] = "shelterScene"
                    }
                },
                ["delayScene"] = new Dictionary<string, object>
                {
                    ["text"] = "Opting for caution, you navigate around the perimeter of the frozen lake, only to discover the storm's sudden escalation during your circumnavigation. Now confronted with deteriorating conditions, do you choose to forge ahead, confronting the intensifying tempest head-on despite the risks? Or do you consider hastily constructing a shelter, mindful that this decision may delay your critical mission, yet providing a chance to seek refuge from the relentless fury of the storm? <br><br>PROCEED / SHELTER",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["proceed"] = "cliffDeathScene",
                        ["shelter"] = "shelterScene"
                    }
                },
                ["cliffDeathScene"] = new Dictionary<string, object>
                {
                    ["text"] = "Pressing forward with unwavering determination through the blinding blizzard, the ferocity of the storm obscures your path entirely. Disoriented and engulfed by the harsh conditions, your footing falters, and you inadvertently tumble over the edge of a concealed cliff, plummeting into the abyss below. The chilling realization sets in as your journey meets a sudden, tragic end. Game Over. <br><br>Would you like to play again? <br><br>YES / NO",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["yes"] = "start",
                        ["no"] = null
                    }
                },
                ["crevasseScene"] = new Dictionary<string, object>
                {
                    ["text"] = "Persisting onward through the relentless blizzard without your torch, the surrounding darkness obscures the treacherous crevasse lying in your path. Unable to discern the hidden danger ahead, you unwittingly stumble into the gaping chasm, plummeting into its icy depths. Your journey meets a sudden, tragic end. Game Over. Would you like to play again? <br><br>YES / NO",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["yes"] = "start",
                        ["no"] = null
                    }
                },
                ["lakeScene"] = new Dictionary<string, object>
                {
                    ["text"] = "Having chosen the risky path of crossing the ice-covered lake, your decision proves perilous as the brittle surface gives way beneath you. Emerging soaked and shivering from the freezing waters, your immediate concern is to dry off and regain warmth. Will you hastily construct a fire, seeking immediate heat against the freezing chill? Or do you consider building a shelter, providing a more sustained refuge against the harsh elements? <br><br>FIRE / SHELTER",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["fire"] = "fireDeathScene2",
                        ["shelter"] = "shelterScene"
                    }
                },
                ["shelterScene"] = new Dictionary<string, object>
                {
                    ["text"] = "Swiftly fashioning a sturdy shelter that shields you from the storm's wrath, you build a warming fire, you awaken to the serenity following the tempest's retreat. Setting forth towards the distant sight of the stricken ship, you encounter a formidable challenge—an impassable, fast-flowing river lies ahead. Do you choose to scout upstream for a safer crossing point? Alternatively, will you venture downstream in pursuit of a more navigable section? <br><br>UPSTREAM / DOWNSTREAM",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["upstream"] = "upStreamScene",
                        ["downstream"] = "downStreamScene"
                    }
                },
                ["upStreamScene"] = new Dictionary<string, object>
                {
                    ["text"] = "Advancing upstream, after a brief journey, you come upon a narrowing in the river, yet the current remains robust. Do you wish to persist in seeking an alternative crossing further upstream or attempt to navigate the current? <br><br>CONTINUE / CROSS",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["continue"] = "continueUpRiverScene",
                        ["cross"] = "riverDeathScene"
                    }
                },
                ["continueUpRiverScene"] = new Dictionary<string, object>
                {
                    ["text"] = "Continuing your exploration upstream, you discover a fallen dead tree spanning the river—a precarious but safe passage across. However, your progress leads you to confront a towering cliff. Will you endeavor to ascend the cliff's face or seek an alternative path around it? <br><br>CLIMB / GO AROUND",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["climb"] = "climbCliffScene",
                        ["go around"] = "creatureDeathScene"
                    }
                },
                ["climbCliffScene"] = new Dictionary<string, object>
                {
                    ["text"] = "Scaling the cliff's face with determination, you conquer the ascent and arrive safely at its summit. From this elevated viewpoint, you discern the distant silhouette of the DR's ship nestled at the base of the frozen hill. The descent ahead appears perilously steep, while a few hundred feet away, a rocky terrain promises a potentially easier route. Amidst this decision-making moment, your gaze catches sight of a mysterious creature stealthily approaching the vicinity of the ship. Despite this unforeseen development, will you brave the daunting descent or opt for the seemingly more traversable but timely rocky terrain route? <br><br>DESCEND / ROCKS",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["descend"] = "winScene1",
                        ["rocks"] = "outOfTimeScene2"
                    }
                },
                ["creatureDeathScene"] = new Dictionary<string, object>
                {
                    ["text"] = "While scouting for an alternate path, your exploration leads you unwittingly into the lair of a fearsome creature. Before you can react, the creature pounces with ferocity, and you are swiftly overtaken, meeting a grim fate. Game Over. <br><br>Would you like to play again? <br><br>YES / NO",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["yes"] = "start",
                        ["no"] = null
                    }
                },
                ["downStreamScene"] = new Dictionary<string, object>
                {
                    ["text"] = "As you journey downstream, the river gradually expands, widening its expanse. Faced with this change, do you contemplate attempting to cross the now broader river or consider constructing a raft for safer passage? <br><br>CROSS / RAFT",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["cross"] = "riverDeathScene",
                        ["raft"] = "raftScene"
                    }
                },
                ["raftScene"] = new Dictionary<string, object>
                {
                    ["text"] = "As you skillfully fashion a sturdy raft and commence your crossing, the river's current proves far stronger than anticipated, swiftly propelling you downstream. Halfway across, confronted with this unexpected challenge, do you choose to remain on the raft, endeavoring to navigate to the opposite shore? Or do you opt to leap into the water, attempting to swim the remaining distance to safety? <br><br>STAY / JUMP",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["stay"] = "raftDeathScene",
                        ["jump"] = "riverSwimScene"
                    }
                },
                ["riverSwimScene"] = new Dictionary<string, object>
                {
                    ["text"] = "Plunging into the icy waters, you encounter a current fiercer than anticipated. Despite the challenge, your determination prevails as you seize hold of a sturdy vine, using it to pull yourself to the safety of the shore. However, the biting cold leaves you shivering uncontrollably. Your attention is drawn to a sight—a mysterious creature stealthily approaching the vicinity of the ship. Despite this unexpected encounter, do you prioritize warming yourself by stripping and drying your soaked clothes, or do you endure the biting cold and press on toward the ship, despite the creature's presence? <br><br>DRY OFF / PUSH ON",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["dry off"] = "outOfTimeScene1",
                        ["push on"] = "winScene2"
                    }
                },
                ["raftDeathScene"] = new Dictionary<string, object>
                {
                    ["text"] = "Persisting in your attempt to reach the shore, you struggle against the unyielding current. Regrettably, your efforts prove futile as the powerful stream propels you relentlessly towards a looming waterfall downstream. Despite your last-minute realization, it's too late to avert the tragic outcome. You succumb to the overwhelming force of the crushing fall. Game Over. <br><br>Would you like to play again? <br><br>YES / NO",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["yes"] = "start",
                        ["no"] = null
                    }
                },
                ["riverDeathScene"] = new Dictionary<string, object>
                {
                    ["text"] = "As you endeavor to navigate across the river, the forceful current proves insurmountable. Despite your efforts, you're unable to withstand its strength, succumbing to the relentless waters. Tragically, you drown in the overpowering current. Game Over. <br><br>Would you like to play again? <br><br>YES / NO",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["yes"] = "start",
                        ["no"] = null
                    }
                }
                ["outOfTimeScene1"] = new Dictionary<string, object>
                {
                    ["text"] = "Having stripped down and dried your clothes by a crackling fire, you set out toward the ship with renewed determination. However, upon arrival, a distressing sight meets your eyes, the creature ravaging on the remains of the doctor. Your delay has led to this grim outcome. Time has proven to be your adversary. Game Over. Would you like to play again? <br><br>YES / NO",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["yes"] = "start",
                        ["no"] = null
                    }
                },
                ["outOfTimeScene2"] = new Dictionary<string, object>
                {
                    ["text"] = "Navigating towards the rocks, you descend the hillside safely, skillfully maneuvering down the steep terrain. However, upon reaching the ship at the bottom, a haunting scene unfolds before you, the creature engorging itself on the doctor's remains. Regrettably, your delay has led to this grim outcome. Time has proven to be your adversary once again. Game Over. Would you like to play again? <br><br>YES / NO",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["yes"] = "start",
                        ["no"] = null
                    }
                },
                ["winScene1"] = new Dictionary<string, object>
                {
                    ["text"] = "You descend the icy gradient but slip and plummet to the bottom, luckily you come to rest in a mound of soft snow. You reach the ship where you find the Dr but!!!",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["option1"] = "",
                        ["option2"] = ""
                    }
                },
                ["winScene2"] = new Dictionary<string, object>
                {
                    ["text"] = "You push on and reach the ship where you find the Dr but!!!",
                    ["image"] = "",
                    ["options"] = new Dictionary<string, string>
                    {
                        ["option1"] = "",
                        ["option2"] = ""
                    }
                }
                
                
            };

            return Ok(storyData);
        }
    }
}