class User {
  constructor(email, password) {
    this.email = email;
    this.password = password;
    this.saveToLocalStorage();
  }

  saveToLocalStorage() {
    localStorage.setItem("emailField", this.email);
    localStorage.setItem("passwordField", this.password);
  }

  static getUserFromLocalStorage() {
    const storedEmail = localStorage.getItem("emailField");
    const storedPassword = localStorage.getItem("passwordField");
    return new User(storedEmail, storedPassword);
  }

  login(enteredEmail, enteredPassword) {
    return enteredEmail === this.email && enteredPassword === this.password;
  }
}

let playerName = "";
let playerInput = "";
let email = "";
let password = "";
let storedEmail = localStorage.getItem("email");
let storedPassword = localStorage.getItem("password");
let enteredEmail = "";
let enteredPassword = "";
let backgroundImage = "";

//  Function to move to home screen
function homePage() {
  location.reload();
}

//  Function to move to login screen
function loginPage() {
  document.getElementById("frontPage").classList.add("hidden");
  document.getElementById("loginPage").classList.remove("hidden");
  document.getElementById("registerPage").classList.add("hidden");
  document.getElementById("mainMenuPage").classList.add("hidden");
  document.getElementById("resumeMainMenuPage").classList.add("hidden");
  document.getElementById("genderPage").classList.add("hidden");
  document.getElementById("charPage").classList.add("hidden");
  document.getElementById("gamePage").classList.add("hidden");
  document.getElementById("creditsPage").classList.add("hidden");
  document.getElementById("emailField").value = "";
  document.getElementById("passwordField").value = "";
}

//  Function to move to register screen
function registerPage() {
  document.getElementById("frontPage").classList.add("hidden");
  document.getElementById("loginPage").classList.add("hidden");
  document.getElementById("registerPage").classList.remove("hidden");
  document.getElementById("mainMenuPage").classList.add("hidden");
  document.getElementById("resumeMainMenuPage").classList.add("hidden");
  document.getElementById("genderPage").classList.add("hidden");
  document.getElementById("charPage").classList.add("hidden");
  document.getElementById("gamePage").classList.add("hidden");
  document.getElementById("creditsPage").classList.add("hidden");
  document.getElementById("emailField").value = "";
  document.getElementById("passwordField").value = "";
}

//  Function to move to main menu screen
function mainMenuPage() {
  document.getElementById("frontPage").classList.add("hidden");
  document.getElementById("loginPage").classList.add("hidden");
  document.getElementById("registerPage").classList.add("hidden");
  document.getElementById("mainMenuPage").classList.remove("hidden");
  document.getElementById("resumeMainMenuPage").classList.add("hidden");
  document.getElementById("genderPage").classList.add("hidden");
  document.getElementById("charPage").classList.add("hidden");
  document.getElementById("gamePage").classList.add("hidden");
  document.getElementById("creditsPage").classList.add("hidden");
}

//  Function to move to main menu screen once game started
function resumeMainMenuPage() {
  document.getElementById("frontPage").classList.add("hidden");
  document.getElementById("loginPage").classList.add("hidden");
  document.getElementById("registerPage").classList.add("hidden");
  document.getElementById("mainMenuPage").classList.add("hidden");
  document.getElementById("resumeMainMenuPage").classList.remove("hidden");
  document.getElementById("genderPage").classList.add("hidden");
  document.getElementById("charPage").classList.add("hidden");
  document.getElementById("gamePage").classList.add("hidden");
  document.getElementById("creditsPage").classList.add("hidden");
  muteGameSound();
  unmuteSound();
}

//  Function to move to gender screen
function genderPage() {
  document.getElementById("frontPage").classList.add("hidden");
  document.getElementById("loginPage").classList.add("hidden");
  document.getElementById("registerPage").classList.add("hidden");
  document.getElementById("mainMenuPage").classList.add("hidden");
  document.getElementById("resumeMainMenuPage").classList.add("hidden");
  document.getElementById("genderPage").classList.remove("hidden");
  document.getElementById("charPage").classList.add("hidden");
  document.getElementById("gamePage").classList.add("hidden");
  document.getElementById("creditsPage").classList.add("hidden");
}

//  Function to move to name screen
function newGame() {
  document.getElementById("frontPage").classList.add("hidden");
  document.getElementById("loginPage").classList.add("hidden");
  document.getElementById("registerPage").classList.add("hidden");
  document.getElementById("mainMenuPage").classList.add("hidden");
  document.getElementById("resumeMainMenuPage").classList.add("hidden");
  document.getElementById("genderPage").classList.add("hidden");
  document.getElementById("charPage").classList.remove("hidden");
  document.getElementById("gamePage").classList.add("hidden");
  document.getElementById("creditsPage").classList.add("hidden");
  playPing();
}

//  Function to move to credits screen
function credits() {
  document.getElementById("frontPage").classList.add("hidden");
  document.getElementById("loginPage").classList.add("hidden");
  document.getElementById("registerPage").classList.add("hidden");
  document.getElementById("mainMenuPage").classList.add("hidden");
  document.getElementById("resumeMainMenuPage").classList.add("hidden");
  document.getElementById("genderPage").classList.add("hidden");
  document.getElementById("charPage").classList.add("hidden");
  document.getElementById("gamePage").classList.add("hidden");
  document.getElementById("creditsPage").classList.remove("hidden");
  playPing();
}

//  Function to move to game page
function gamePage() {
  document.getElementById("frontPage").classList.add("hidden");
  document.getElementById("loginPage").classList.add("hidden");
  document.getElementById("registerPage").classList.add("hidden");
  document.getElementById("genderPage").classList.add("hidden");
  document.getElementById("mainMenuPage").classList.add("hidden");
  document.getElementById("resumeMainMenuPage").classList.add("hidden");
  document.getElementById("charPage").classList.add("hidden");
  document.getElementById("gamePage").classList.remove("hidden");
  document.getElementById("creditsPage").classList.add("hidden");
  document.getElementById("audioButton").classList.add("hidden");
  document.getElementById("audioButtonMute").classList.add("hidden");
  document.getElementById("gameAudioButtonMute").classList.add("hidden");
  document.getElementById("gameAudioButton").classList.remove("hidden");
  muteSound();
  unmuteGameSound();
}

//  Function to authenticate login
function login() {
  const enteredEmail = document.getElementById("loginEmailField").value;
  const enteredPassword = document.getElementById("loginPasswordField").value;

  const user = User.getUserFromLocalStorage();
  if (user.login(enteredEmail, enteredPassword)) {
    mainMenuPage();
  } else {
    alert("Wrong login details. Please try again.");
  }
}

//  Function to save register details - to be completed
function registerDetails() {
  const email = document.getElementById("emailField").value;
  const password = document.getElementById("passwordField").value;

  if (email === "" || password === "") {
    alert("Enter Details!");
  } else {
    const user = new User(email, password);
    console.log(localStorage);
    mainMenuPage();
  }
}

// Funcion to play the boom sound when clicking Enter Game
function playBoom() {
  let playBoom = document.getElementById("enterGameButtonAudio");
  playBoom.volume = 0.3;
  playBoom.play();
}

// Funcion to play the ping sound when clicking choosing gender
function playPing() {
  let playPing = document.getElementById("genderSelectButtonAudio");
  playPing.volume = 0.2;
  playPing.play();
}

// Funcion to mute the main sound
function muteSound() {
  let muteMain = document.getElementById("mainAudio");
  document.getElementById("gameAudioButtonMute").classList.add("hidden");
  document.getElementById("gameAudioButton").classList.add("hidden");
  document.getElementById("audioButton").classList.add("hidden");
  document.getElementById("audioButtonMute").classList.remove("hidden");
  muteMain.pause();
}

// Funcion to play the main sound
function unmuteSound() {
  let unmuteMain = document.getElementById("mainAudio");
  document.getElementById("gameAudioButtonMute").classList.add("hidden");
  document.getElementById("gameAudioButton").classList.add("hidden");
  document.getElementById("audioButton").classList.remove("hidden");
  document.getElementById("audioButtonMute").classList.add("hidden");
  unmuteMain.volume = 0.5;
  unmuteMain.play();
}

// Funcion to mute the game sound
function muteGameSound() {
  let muteGame = document.getElementById("gameAudio");
  document.getElementById("gameAudioButtonMute").classList.remove("hidden");
  document.getElementById("gameAudioButton").classList.add("hidden");
  document.getElementById("audioButton").classList.add("hidden");
  document.getElementById("audioButtonMute").classList.add("hidden");
  muteGame.pause();
}

// Funcion to play the game sound
function unmuteGameSound() {
  let unmuteGame = document.getElementById("gameAudio");
  document.getElementById("gameAudioButtonMute").classList.add("hidden");
  document.getElementById("gameAudioButton").classList.remove("hidden");
  document.getElementById("audioButton").classList.add("hidden");
  document.getElementById("audioButtonMute").classList.add("hidden");
  unmuteGame.volume = 0.25;
  unmuteGame.play();
}

// Function to change bodytype selection image
function bodytype2() {
  document.getElementById("bodytypeImage").src = "Images/femalePopout.png";
}

// Function to change bodytype selection image
function bodytype1() {
  document.getElementById("bodytypeImage").src = "Images/malePopout.png";
}

//  Function to store the char name and starts game
function getInputValue() {
  playerName = document.getElementById("inputField").value;

  if (playerName == "") {
    alert("Choose a name!");
  } else {
    displayScene();
    document.getElementById("frontPage").classList.add("hidden");
    document.getElementById("loginPage").classList.add("hidden");
    document.getElementById("registerPage").classList.add("hidden");
    document.getElementById("genderPage").classList.add("hidden");
    document.getElementById("mainMenuPage").classList.add("hidden");
    document.getElementById("resumeMainMenuPage").classList.add("hidden");
    document.getElementById("charPage").classList.add("hidden");
    document.getElementById("gamePage").classList.remove("hidden");
    document.getElementById("creditsPage").classList.add("hidden");
    document.getElementById("audioButton").classList.add("hidden");
    document.getElementById("audioButtonMute").classList.add("hidden");
    document.getElementById("gameAudioButtonMute").classList.add("hidden");
    document.getElementById("gameAudioButton").classList.remove("hidden");
    document.getElementById("playersName").innerHTML = playerName;
    muteSound();
    unmuteGameSound();
    playBoom();
    return playerName;
  }
}

const output = document.getElementById("output");
const outputError = document.getElementById("outputError");
const input = document.getElementById("playerInput");

// Sets currentScene to null initially
let currentScene = null;

// Function to display text and update the game state
function displayScene() {
  if (currentScene) {
    output.innerHTML = currentScene.text.replace("_name_", playerName);
    input.value = "";
    backgroundImage = `url('${currentScene.image}')`;
    cardContent.style.backgroundImage = backgroundImage;
  } else {
    // Handle the case where currentScene is null or invalid
    console.error("Invalid currentScene.");
  }
}

// Handle user input
input.addEventListener("keydown", async function (event) {
  if (event.key === "Enter") {
    const choice = input.value.toLowerCase();
    if (currentScene && currentScene.options[choice]) {
      const nextSceneKey = currentScene.options[choice];
      try {
        const response = await fetch("http://localhost:5090/api/games/story");
        const gameTree = await response.json();

        currentScene = gameTree[nextSceneKey];
        displayScene();

        if (!currentScene) {
          input.disabled = true;
        }
      } catch (error) {
        console.error("Error fetching or updating game tree:", error);
      }
    } else {
      outputError.innerHTML = "Invalid choice. Try again.";
      input.value = "";
    }
    setTimeout(functionToDisappearInnerHTML, 2500);
  }
});

// Fetch the game tree and start the game
async function startGame() {
  try {
    const response = await fetch("http://localhost:5090/api/games/story");
    const gameTreeData = await response.json();
    currentScene = gameTreeData.start;
    displayScene();
  } catch (error) {
    console.error("Error fetching or initializing game tree:", error);
  }
}

// Call the function to start the game
startGame();

// Function to make the output error text disappear
function functionToDisappearInnerHTML() {
  document.getElementById("outputError").innerHTML = "";
}

// Get the cardContent element
const cardContent = document.getElementById("dynamicBackground");

// Add the 'dynamicBackground' class to the element
cardContent.classList.add("dynamicBackground");

// Set the background image using inline style
cardContent.style.backgroundImage = `url('${backgroundImage}')`;