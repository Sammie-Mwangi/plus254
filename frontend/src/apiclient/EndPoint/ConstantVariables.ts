// Backend Base Url
export const BACKEND_BASE_URL =
  process.env.NODE_ENV !== "production"
    ? "https://localhost:5001/api/v1/"
    : "https://localhost:5001/api/v1/";

// Local Storage  Key
export const STORAGE_KEY = "DO-NOT-SHARE-THIS-WITH-ANYONE-WHO-ASKS";

// Token
export const MY_TOKEN_KEY = "MY_TOKEN";
