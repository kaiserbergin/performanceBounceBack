# Performance Bounceback Starter Project

This project is part of [Udacity](https://www.udacity.com "Udacity - Be in demand")'s [VR Developer Nanodegree](https://www.udacity.com/course/vr-developer-nanodegree--nd017).

## Versions
- Unity 2017.2.0f3

I've tried many times to bake lights and each time it goes all the way through the process and then says "Baking lighting data asset failed." - I've tried both enlighten and progressive.  

In editor, the framerate is hosed due to waitForFrame and EditorOverhead - each of these happen for me on other VR scenes and objects, so I just took them out of the profiler and was achieving 220 - 270 fps.  The build performed well, so I think it should be fine.  
