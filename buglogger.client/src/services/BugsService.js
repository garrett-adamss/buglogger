import { AppState } from "../AppState"
import { logger } from "../utils/Logger"
import { api } from "./AxiosService"

class BugsService{
    async getAll(){
        const res = await api.get('api/bugs')
        // logger.log("[res.data getAll]", res.data)
        // AppState.bugs = res.data
        
    }
}
export const bugsService = new BugsService()