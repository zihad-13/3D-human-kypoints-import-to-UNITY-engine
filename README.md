# 3D-human-kypoints-import-to-unity

## Steps
1. Copy the unity project to the local directory.
2. Open with editor(try to use latest)
3. Press Run

## 3D keypoints
Generate 3D keypoints from https://github.com/zihad-13/3D-human-pose-estimation-yolov7-evoskeleton
and copy the saved ```.csv``` file to the unity project. Provide the csv filename in ```Assets/Animate.cs``` script attached to the character. This can be done from the inspector.

Here the following character is used.
https://free3d.com/3d-model/manuel-animated-001-dancing-256270.html

# Output
https://user-images.githubusercontent.com/38187481/220135192-4a0fdd04-0cc9-4533-ba71-ec557e003810.mp4

### TODO
Add tracker to smooth the pose. \n
Apply IK.

# Acknowledgement
https://github.com/laxmaniron/3D-Animation
video : https://www.youtube.com/watch?v=_FcrGLCHT08
