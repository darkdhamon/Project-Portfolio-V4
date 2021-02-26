export interface ProjectCard {
  id:number;
  name: string;
  shortDescription: string;
  demoUrl: string;
  sourceUrl: string;
  imageDataUrl: string;
}

export interface Project extends ProjectCard{
  description: string;
  endDate: Date;
  startDate: Date;
}
