#include "TutorialEditor.h"
#include "Modules/ModuleManager.h"
#include "Modules/ModuleInterface.h"

IMPLEMENT_GAME_MODULE(FTutorialEditorModule, TutorialEditor);

#define LOCTEXT_NAMESPACE "TutorialEditor"

void FTutorialEditorModule::StartupModule()
{
    UE_LOG(TutorialEditor, Warning, TEXT("TutorialEditor: Log Started"));
}

void FTutorialEditorModule::ShutdownModule()
{
    UE_LOG(TutorialEditor, Warning, TEXT("TutorialEditor: Log Ended"));
}

#undef LOCTEXT_NAMESPACE
