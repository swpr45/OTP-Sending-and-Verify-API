


# OTP Generation and Verification API

🔐 Secure your ASP.NET Web API with OTP using Twilio

## Overview

This project provides a robust API for one-time password (OTP) generation and verification in ASP.NET Web API. It utilizes Twilio for secure OTP delivery via SMS.

## Getting Started

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/yourusername/otp-web-api.git
   cd otp-web-api
   ```

2. **Update Database Connection String:**
   Open `appsettings.json` and replace the placeholder in the `ConnectionStrings` section with your database connection string.

   ```json
   "ConnectionStrings": {
      "DefaultConnection": "your_database_connection_string"
   }
   ```

3. **Set up Twilio Credentials:**
   - Create a Twilio account at [Twilio Website](https://www.twilio.com/try-twilio).
   - Obtain your Account SID and Auth Token from the Twilio Dashboard.
   - Update the Twilio credentials in `appsettings.json`.

   ```json
   "Twilio": {
      "AccountSid": "your_twilio_account_sid",
      "AuthToken": "your_twilio_auth_token",
      "PhoneNumber": "your_twilio_phone_number"
   }
   ```

## Run the Application

1. Build and run the application using Visual Studio or your preferred development environment.

2. Access the API at `http://localhost:your_port_number`.

## API Endpoints

- **Generate OTP:**
  ```http
  POST /api/otp/"mobile number"
  ```

- **Verify OTP:**
  ```http
  POST /api/otp/
  ```


## License

This project is licensed under the MIT License.

