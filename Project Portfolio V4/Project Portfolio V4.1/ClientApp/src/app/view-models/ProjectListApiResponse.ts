import { Project } from '../view-models/Project';

export interface ProjectListApiResponse {
  data: Project[];
  status: string;
  message: string;
}
