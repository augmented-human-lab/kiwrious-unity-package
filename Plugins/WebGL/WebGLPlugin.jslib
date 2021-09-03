// Creating functions for the Unity
mergeInto(LibraryManager.library, {

   // Function example
   CallFunction: function () {
      // Show a message as an alert
         console.log("You called a function from this plugin!");
         navigator.serial.requestPort({
            filters: [{ usbVendorId: 0x04d8, vendorId: 0x04d8 }, { usbVendorId: 0x0d28, usbProductId: 0x0204 }],
         });
   },

   // Function with the text param
   PassTextParam: function (text) {
      // Convert bytes to the text
      var convertedText = Pointer_stringify(text);

      // Show a message as an alert
      window.alert("You've passed the text: " + convertedText);
   },

   // Function with the number param
   PassNumberParam: function (number) {
      // Show a message as an alert
      window.alert("The number is: " + number);
   },

   // Function returning text value
   GetTextValue: function () {
      // Define text value
      var textToPass = "You got this text from the plugin";

      // Create a buffer to convert text to bytes
      var bufferSize = lengthBytesUTF8(textToPass) + 1;
      var buffer = _malloc(bufferSize);

      // Convert text
      stringToUTF8(textToPass, buffer, bufferSize);

      // Return text value
      return buffer;
   },

   // Function returning number value
   GetNumberValue: function () {
      // Return number value
      return 2020;
   }
});