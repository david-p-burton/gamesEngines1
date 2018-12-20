# DIT Games Engines 1 Assignment

## Assignment Demo; Audio Responsive Particle System

### Description
This repo holds my Unity project for Games Engines 1. It is a particle system that reacts to the audio that it is using. As the project exists now on this repo, it plays the song D by Truxton. This project will work with other songs, but for testing and demo purposes I have found that this song works quite well to show off the various frequency ranges that are used in an average song. Madeon's Finale is also included for the purposes of seeing what a different song would look like with the project.

The project makes use of particle systems. These systems are a great use in Unity and take a lot of the tough work out of having to design one's own systems for generating and cleaning up after particle emission. 

The system rotates slowly around the centre of the scene. Particles are emitted as the songs frequency bands rise and fall in value. For the base and sub-bass (red particles in this project), I found that I had to boost the signal in order to get a noticeable emission of particles. The entire scene is contained within a ball. There are also two other elements. A cube and a sphere rotating each other rotate around the scene. These two were added to give the sense of space as due to the rotation of these objects, they will appear sometimes in front of and sometimes behind the particles. This was added as the camera occasionally moves around (by design!), so these objects will give the viewer some grounding as to where they are in the scene occasionally. The cube also changes size with respect to the bass frequency.


### Who Developed What?
Of the assets in this project, here are the scripts taken from the course;

FPSController

audioAnalyser


### Most Proud
I am most proud of how the whole thing came together. When the bass kicks in in the song, I think its pretty cool how you can see the bass starting and stopping as per the song. I am also pleased with the camera movements as they turned out smooth and the location swapping based on bars of the song elapsed is also pretty nice.


### Instructions
So I developed this on a Windows 10 machine, but I attempted to demo this project on my Late 2013 MacbookPro. I had issues with the project once I opened it on the macbook due to version differences. If you are running this on a mac system, please checkout the macDemo branch and use that. If you are using a windows based system, use the master branch.


### Video

[![YouTube](http://img.youtube.com/vi/XZQKlqtfODk/0.jpg)](https://www.youtube.com/watch?v=XZQKlqtfODk)
