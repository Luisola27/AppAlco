import axios from "axios";
import { getWebSiteAPI, HEADERS } from "../config/config";

export async function GeneralCall(
    endpoint,
    method = 'GET',
    data = {},
    source = null
) {
    const webSiteAPI = await getWebSiteAPI();
    const config = {
        headers: HEADERS,
        cancelToken: source,
    };

    let response;

    try{
        switch(method.toUpperCase()) {
            case 'GET':
                response = await axios.get(`${webSiteAPI}/${endpoint}`, config);
                break;
            case 'POST':
                response = await axios.post(`${webSiteAPI}/${endpoint}`, data, config);
                break;
            case 'PUT':
                response = await axios.put(`${webSiteAPI}/${endpoint}`, data, config);
                break;
            case 'DELETE':
                response = await axios.delete(`${webSiteAPI}/${endpoint}`, config);
                break;
            default:
                throw new Error(`Unsupported request method: ${method}`);
        }
        return response;
    } catch(thrown) {
        if (axios.isCancel(thrown)){
            console.log('Request canceled', thrown.message);
        } else {
            console.log(`Error with ${method} request to ${endpoint}:`, thrown);
        }
        return {};
    }
}