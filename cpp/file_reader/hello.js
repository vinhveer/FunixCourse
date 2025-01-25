// Test 1: Kiểm tra cơ bản
$.ajax({
    url: '/TrainingOfficer/AdminClasses64132989/GetStudentList',
    method: 'GET',
    data: {
        classId: '64CNTT3'
    },
    success: function(response) {
        console.log('Success:', response);
    },
    error: function(xhr, status, error) {
        console.error('Error:', error);
    }
});

// Test 2: Kiểm tra với đầy đủ tham số phân trang và sắp xếp
$.ajax({
    url: '/TrainingOfficer/AdminClasses64132989/GetStudentList',
    method: 'GET',
    data: {
        offset: 0,
        limit: 10,
        search: '',
        sort: 'userId',
        order: 'asc',
        classId: '64CNTT3'
    },
    success: function(response) {
        console.log('Success:', response);
        console.log('Total records:', response.total);
        console.log('Rows:', response.rows);
    },
    error: function(xhr, status, error) {
        console.error('Error:', error);
    }
});

// Test 3: Kiểm tra với tìm kiếm
$.ajax({
    url: '/TrainingOfficer/AdminClasses64132989/GetStudentList',
    method: 'GET',
    data: {
        offset: 0,
        limit: 10,
        search: 'Vinh', // Thay thế bằng từ khóa tìm kiếm thực tế
        sort: 'userId',
        order: 'asc',
        classId: '64CNTT3'
    },
    success: function(response) {
        console.log('Searched results:', response);
    },
    error: function(xhr, status, error) {
        console.error('Error:', error);
    }
});

// Test 4: Sử dụng Fetch API (phiên bản hiện đại hơn)
fetch('/TrainingOfficer/AdminClasses64132989/GetStudentList?classId=64CNTT3&offset=0&limit=10', {
    method: 'GET',
    headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
    }
})
.then(response => response.json())
.then(data => {
    console.log('Data received:', data);
})
.catch(error => {
    console.error('Error:', error);
});

// Test 5: Kiểm tra với Postman
/*
URL: https://localhost:44348/TrainingOfficer/AdminClasses64132989/GetStudentList
Method: GET
Parameters:
    classId: 64CNTT3
    offset: 0
    limit: 10
    search: 
    sort: userId
    order: asc
Headers:
    Accept: application/json
    Content-Type: application/json
*/

// Test 6: Curl Command để test API
/*
curl -X GET "https://localhost:44348/TrainingOfficer/AdminClasses64132989/GetStudentList?classId=64CNTT3&offset=0&limit=10&sort=userId&order=asc" -H "accept: application/json"
*/