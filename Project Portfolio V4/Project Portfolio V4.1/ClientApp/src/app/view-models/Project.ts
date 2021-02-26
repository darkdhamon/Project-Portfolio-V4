export class ProjectCard {
  id:number | undefined;
  name: string | undefined;
  shortDescription: string | undefined;
  demoUrl: string | undefined;
  sourceUrl: string | undefined;
  imageDataUrl: string | undefined;
}

export class Project extends ProjectCard{
  description: string | undefined;
  endDate: Date | undefined;
  startDate: Date | undefined;
}
