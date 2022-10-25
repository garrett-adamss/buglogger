import { logger } from "../utils/Logger"
import { api } from "./AxiosService"

class ProjectsService{
    async GetAll(){
        const res = await api.get('api/projects')
        logger.log("res.data", res.data)
    }
}

export const projectsService = new ProjectsService