<img alt="GitHub Actions Workflow Status" src="https://img.shields.io/github/actions/workflow/status/jav76/MTG-Recognition-Model/Build.yml?style=for-the-badge&label=CI%20Build&link=https%3A%2F%2Fgithub.com%2Fjav76%2FMTG-Recognition-Model%2Factions%2Fworkflows%2FBuild.yml">
<img alt="GitHub Actions Workflow Status" src="https://img.shields.io/github/actions/workflow/status/jav76/MTG-Recognition-Model/Publish.yml?style=for-the-badge&label=Release%20Build&link=https%3A%2F%2Fgithub.com%2Fjav76%2FMTG-Recognition-Model%2Factions%2Fworkflows%2FPublish.yml">


<img alt="GitHub License" src="https://img.shields.io/github/license/jav76/MTG-Recognition-Model?style=for-the-badge&link=https%3A%2F%2Fgithub.com%2Fjav76%2FMTG-Recognition-Model%2Fblob%2Fmain%2FLICENSE">
<img alt="CodeFactor Grade" src="https://img.shields.io/codefactor/grade/github/jav76/MTG-Recognition-Model?style=for-the-badge&link=https%3A%2F%2Fwww.codefactor.io%2Frepository%2Fgithub%2Fjav76%2Fmtg-recognition-model%2Fstats">


# MTG Recognition

The intent of this project is eventually going to be to train some sort of model to recognize Magic the Gathering cards from images. 
The general workflow will be to first use the Scryfall API to download "clean" images of cards along with the card data, and store that information in something like a SqlLite database. That data can then be matched up to the card image. 
Once the basic foundation is built for clean data, some sort of interface for uploading real world images could be used for additional training.


## Overview and Project Structure

Lots of TODOs here. The `MTGRecognition` project is the main entry-point. I'd like to build a shell or something around this eventually. The only other project currently is the `MTGDataAccess` project as a library for any data handling.

### MTGRecognition

The entire solution is currently built into a self-contained single-file executable via the github workflow. This produces `MTGRecognition.exe` for different platforms, currently:

- win-x64
- win-x86
- win-arm64
- linux-x64
- linux-arm
- linux-arm64

At this point these platform targets don't have much reasoning besides variety and multi-playform compatibility.

### MTGDataAccess

This project should be used for any sort of data interaction within the solution. This could include API calls and response consumption, file I/O, database access, etc.

#### Scryfall API

Currently the only sort of "data access" is for the Scryfall API.


