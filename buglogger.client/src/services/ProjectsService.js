import { AppState } from "../AppState"
import { logger } from "../utils/Logger"
import { api } from "./AxiosService"

class ProjectsService{
    async getAll(){
        const res = await api.get('api/projects')
        logger.log("res.data", res.data)
        AppState.projects = res.data
    }
    async getOne(id){
        const res = await api.get(`api/projects/${id}`)
        AppState.activeProject = res.data
        logger.log("[Active Project]", AppState.activeProject)

    }
}

export const projectsService = new ProjectsService