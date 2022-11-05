import { AppState } from "../AppState"
import { logger } from "../utils/Logger"
import { api } from "./AxiosService"

class BugsService{
    async getAll(){
        const res = await api.get('api/bugs')
        logger.log("[ getAll, res.data]", res.data)
        AppState.bugs = res.data
    }
    async getOne(id){
        const res = await api.get(`api/bugs/${id}`)
        logger.log("[getOne, res.data]", res.data)
        AppState.activeBug = res.data
    }
}
export const bugsService = new BugsService()