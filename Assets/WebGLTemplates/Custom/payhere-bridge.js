var PayHereBridge = {
    initPayment: function(merchantId, merchantSecret, amount, currency, customerName, customerEmail, orderId, returnUrl, cancelUrl) {
        // PayHere checkout popup implementation
        var payment = {
            sandbox: true,
            merchant_id: merchantId,
            merchantSecret: merchant_secret,
            return_url: returnUrl,
            cancel_url: cancelUrl,
            notify_url: "",
            order_id: orderId,
            items: "Demo Payment",
            amount: amount,
            currency: currency,
            first_name: customerName.split(" ")[0],
            last_name: customerName.split(" ")[1] || "",
            email: customerEmail,
            phone: "0771234567",
            address: "No.1, Galle Road",
            city: "Colombo"
        };

        PayHere.onCompleted = function onCompleted(orderId) {
            // Payment completed successfully
            SendMessage('PaymentController', 'OnPaymentSuccess', orderId);
        };

        PayHere.onDismissed = function onDismissed() {
            // Payment dismissed
            SendMessage('PaymentController', 'OnPaymentDismissed', '');
        };

        PayHere.onError = function onError(error) {
            // Error occurred
            SendMessage('PaymentController', 'OnPaymentFailed', error);
        };

        PayHere.startPayment(payment);
    }
};