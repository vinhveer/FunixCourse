import cv2
import mediapipe as mp

# Khởi tạo các mô-đun của MediaPipe
mp_hands = mp.solutions.hands
mp_drawing = mp.solutions.drawing_utils

# Cấu hình cho việc phát hiện bàn tay
hands = mp_hands.Hands(
    static_image_mode=False,  # Dùng chế độ video realtime
    max_num_hands=2,         # Số lượng bàn tay tối đa cần nhận diện
    min_detection_confidence=0.5,  # Độ tin cậy tối thiểu để phát hiện bàn tay
    min_tracking_confidence=0.5    # Độ tin cậy tối thiểu để theo dõi bàn tay
)

# Khởi động webcam
cap = cv2.VideoCapture(0)

while cap.isOpened():
    success, frame = cap.read()
    if not success:
        print("Không thể truy cập webcam.")
        break

    # Chuyển đổi màu từ BGR sang RGB (MediaPipe yêu cầu RGB)
    frame_rgb = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)

    # Nhận diện bàn tay trong khung hình
    results = hands.process(frame_rgb)

    # Vẽ các điểm và đường nối lên bàn tay
    if results.multi_hand_landmarks:
        for hand_landmarks in results.multi_hand_landmarks:
            mp_drawing.draw_landmarks(
                frame, hand_landmarks, mp_hands.HAND_CONNECTIONS,
                mp_drawing.DrawingSpec(color=(0, 255, 0), thickness=2, circle_radius=2),
                mp_drawing.DrawingSpec(color=(255, 0, 0), thickness=2)
            )

    # Hiển thị khung hình
    cv2.imshow('Hand Tracking', frame)

    # Thoát chương trình khi nhấn phím 'q'
    if cv2.waitKey(1) & 0xFF == ord('q'):
        break

# Giải phóng tài nguyên
cap.release()
cv2.destroyAllWindows()
