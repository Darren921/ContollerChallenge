Self reflection is at the bottom

Darren - Unity, sofware programming and hardware planning.

Alex - reflections and online Hardware planning

Tasin - Hardware implementation

The goal of this project was to create a unique way of playing Patapon using motion imputs from an accelerometer.

We first created a prototype online using Wokwi to test the inputs.

Then using this as a base we created a prototype to test the inputs. 

<img width="951" height="713" alt="image" src="https://github.com/user-attachments/assets/ada49fda-24c8-443d-8ce7-7d2c61ba9d2f" />

Video of the Wokwi prototype: 



https://github.com/user-attachments/assets/5484ec53-6cc0-4aff-8097-b7a4538be247



Using this as a base we recreated this with the physical hardware that we had 



![rn_image_picker_lib_temp_292455cd-14e1-4821-b156-43c066c3874e](https://github.com/user-attachments/assets/869cbaad-fb56-478b-a34d-176899532258)


Video of the physical prototype: 

https://github.com/user-attachments/assets/e1dd3a90-6487-462e-8292-ae51cfb94643 

To replicate the mechanics of patapon, we recorded each direction of the accelerometer as a unique number, using these numbers we could record the last 4 inputs, and if they matched a predetermined pattern, it would call a variable. 

When testing with the physical model we ran into an issue, the accelerometer was broken and not recording any inputs, this made it impossible to continue with the project as we had no way of recording our inputs. 

![rn_image_picker_lib_temp_292455cd-14e1-4821-b156-43c066c3874e](https://github.com/user-attachments/assets/a2dd0f46-e9c1-4804-a5ee-02fe8dfa7d0f)

<img width="502" height="223" alt="image11" src="https://github.com/user-attachments/assets/6cda999d-9f91-4956-a152-8c2a3a367b79" />



Since we were unable to get the physical model working, We created a mockup in unity to showcase what it would have looked like if it had been working.  


Reflection and final notes:

Darren Chung:/
Originally having issues with Wokwi due to being unfamiliar with the software./
The resistors on Wokwi are larger than in TinkerCad, which caused some issues./
Wokwi documentation was targeted for the Arduino Uno, so caused some confusion with wiring on some components./
Using the Arduino and breadboard is much easier to connect and trouble shoot as not all the wires are on the breadboard itself./
Having 
Most of our difficulties were due to our lack of experience working with custom hardware. /


Alex  H: /
Found out that Ardity does indeed work with any version of unity, it's just that one of the prefabs was broken, after it was deleted it works fine. /
Project would have taken much less time if we were familiar with the software and hardware we were using, if we did this a second time, it would be much quicker/
As someone who is not that experienced with coding, understanding what needed to be done was difficult /
Not familiar with Wokwi which made it difficult to navigate. /



Tasin: 

I accidentally fried the mpu9250 but initial texts were successful./
Hardware implementation was carried out as planned with no wires touching each other./
Maintained safety and avoided any accidental short circuit. /
I would count it as a progress as I had little to no experience in electrical and hardware. / 
Did scare me at first. Checking each connection multiple times before plugging it in./ 


