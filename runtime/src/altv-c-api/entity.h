#pragma once

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wempty-body"
#pragma clang diagnostic ignored "-Wswitch"
#endif

#include <altv-cpp-api/SDK.h>

#ifdef __clang__
#pragma clang diagnostic pop
#endif

#ifdef __cplusplus
extern "C"
{
#endif
/*EXPORT uint16_t Entity_GetID(alt::IEntity* entity);

EXPORT void Entity_GetPositionRef(alt::IEntity* entity, alt::Position &pos);
EXPORT void Entity_SetPositionRef(alt::IEntity* entity, alt::Position* pos);
EXPORT alt::Position Entity_GetPosition(alt::IEntity* entity);
EXPORT void Entity_SetPosition(alt::IEntity* entity, alt::Position pos);
EXPORT void Entity_SetPositionXYZ(alt::IEntity* entity, float x, float y, float z);

EXPORT void Entity_GetRotationRef(alt::IEntity* entity, alt::Rotation &rot);
EXPORT void Entity_SetRotationRef(alt::IEntity* entity, alt::Rotation* rot);
EXPORT alt::Rotation Entity_GetRotation(alt::IEntity* entity);
EXPORT void Entity_SetRotation(alt::IEntity* entity, alt::Rotation rot);
EXPORT void Entity_SetRotationRPY(alt::IEntity* entity, float roll, float pitch, float yaw);

EXPORT uint16_t Entity_GetDimension(alt::IEntity* entity);
EXPORT void Entity_SetDimension(alt::IEntity* entity, uint16_t dimension);

EXPORT void Entity_GetMetaData(alt::IEntity* entity, const char* key, alt::MValue &val);
EXPORT void Entity_SetMetaData(alt::IEntity* entity, const char* key, alt::MValue* val);

EXPORT void Entity_GetSyncedMetaData(alt::IEntity* entity, const char* key, alt::MValue &val);
EXPORT void Entity_SetSyncedMetaData(alt::IEntity* entity, const char* key, alt::MValue* val);*/
#ifdef __cplusplus
}
#endif
