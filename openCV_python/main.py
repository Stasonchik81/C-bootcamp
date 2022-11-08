import cv2

img = cv2.imread('jpg/jack.jpg')
# img = cv2.resize(img, (400, 300))

cv2.imshow('Result', img)
cv2.waitKey(4000)