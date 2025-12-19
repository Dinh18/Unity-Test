1. Thay đổi hình ảnh item:
   - Thay đổi sprite của các item trong thư mục prefabs thành textures fish
2. Chuyển 1 item từ bảng xuống hàng ở dưới:
   - Script Board:
     * Tạo hàm CreateBottomCell trong script Board
     * Tạo script BottomCell: có thuộc tính bottom(chỉ số hàng), item, isEmpty, 2 hàm setup giá trị bottom và Item.
     * Tạo 1 prefab bottom cell background mới gán script BottomCell.
     * Viết hàm CanMove: trả về ô trong hàng dưới có item là null để di chuyển item xuống
  - Script Item:
     * Viết hàm AnimationMoveToBottom(BottomCell btcell): để di chuyển item xuống và set Item btcell là chính nó.
  - Script BoardController: khi người chơi nhả chuột thì di chuyển xuống (sử dụng raycast)
3. Xóa item trùng nhau 3 lần sau khi di chuyển item xuống:
  -   Trong script Board viết hàm CheckBottomCell(): sử dụng list để lưu vị trí các item cùng nhau, nếu count > 3 xóa tại các vị trí đó đi.
  -   Trong script BoardController: viết hàm CountCheck sử dụng IEnumrator để delay thời gian xóa các item được gọi ngay khi di chuyển item xuống dưới.
4. Hiển thị màn hình winning và losing:
  - Trong GameManager thêm 2 GamObject panelGameOver và panelWin,  
  - Trong script Board: viết 2 hàm IsLosed trả về true khi tất cả các ô trong hàng dưới đều có item khác null và IsWon trả về true khi tất cả các ô trong bảng có item là null.
  - Trong script BoardController: viết 2 hàm CheckWin và CheckLose sử dụng IEnumrator để delay thời gian kiểm tra sau đó hiển thị các panel cần thiết.
    Thứ tự gọi các hàm IEnumrator:
      CountCheck(0.2f);
      CheckWin(0.2f);
      CheckLose(1f);
  
    
    
