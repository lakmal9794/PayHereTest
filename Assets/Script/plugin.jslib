mergeInto(LibraryManager.library, {
  StartPayHerePayment: function () {
    // Ensure PayHere script is already loaded before calling
    if (typeof payhere === "undefined") {
      console.error("PayHere library not loaded!");
      return;
    }

    var payment = {
      "sandbox": true,
      "merchant_id": "1231476",
      "return_url": undefined,
      "cancel_url": undefined,
      "notify_url": undefined,
      "order_id": "ItemNo12345",
      "items": "Door bell wireless",
      "amount": "1000.00",
      "currency": "LKR",
      "hash": "45D3CBA93E9F2189BD630ADFE19AA6DC",
      "first_name": "Saman",
      "last_name": "Perera",
      "email": "samanp@gmail.com",
      "phone": "0771234567",
      "address": "No.1, Galle Road",
      "city": "Colombo",
      "country": "Sri Lanka",
      "delivery_address": "No. 46, Galle road, Kalutara South",
      "delivery_city": "Kalutara",
      "delivery_country": "Sri Lanka",
      "custom_1": "",
      "custom_2": ""
    };

    payhere.onCompleted = function (orderId) {
      console.log("Payment completed. OrderID:" + orderId);
    };

    payhere.onDismissed = function () {
      console.log("Payment dismissed");
    };

    payhere.onError = function (error) {
      console.log("Error:" + error);
    };

    payhere.startPayment(payment);
  }
});
