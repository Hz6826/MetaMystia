using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000075 RID: 117
	public class DLC4_BulletBase : MonoBehaviour
	{
		// Token: 0x06000C75 RID: 3189 RVA: 0x000C7D18 File Offset: 0x000C5F18
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_BulletBase()
		{
			Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_BulletBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr);
			DLC4_BulletBase.NativeFieldInfoPtr_m_BulletIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, "m_BulletIndex");
			DLC4_BulletBase.NativeFieldInfoPtr_m_HitVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, "m_HitVFX");
			DLC4_BulletBase.NativeFieldInfoPtr_m_HitVFXOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, "m_HitVFXOffset");
			DLC4_BulletBase.NativeFieldInfoPtr_HasDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, "HasDisposed");
			DLC4_BulletBase.NativeFieldInfoPtr_lastFrameTargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, "lastFrameTargetPosition");
			DLC4_BulletBase.NativeFieldInfoPtr_recycleCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, "recycleCoroutine");
			DLC4_BulletBase.NativeFieldInfoPtr__Dlc4BossBattleManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, "<Dlc4BossBattleManager>k__BackingField");
			DLC4_BulletBase.NativeFieldInfoPtr__Speed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, "<Speed>k__BackingField");
			DLC4_BulletBase.NativeFieldInfoPtr__DamagePower_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, "<DamagePower>k__BackingField");
			DLC4_BulletBase.NativeMethodInfoPtr_get_BulletIndex_Public_get_BulletTypeIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, 100665418);
			DLC4_BulletBase.NativeMethodInfoPtr_get_Dlc4BossBattleManager_Protected_get_DLC4_BossBattleManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, 100665419);
			DLC4_BulletBase.NativeMethodInfoPtr_set_Dlc4BossBattleManager_Private_set_Void_DLC4_BossBattleManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, 100665420);
			DLC4_BulletBase.NativeMethodInfoPtr_get_BulletShooterType_Public_Abstract_Virtual_New_get_BulletType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, 100665421);
			DLC4_BulletBase.NativeMethodInfoPtr_get_Speed_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, 100665422);
			DLC4_BulletBase.NativeMethodInfoPtr_set_Speed_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, 100665423);
			DLC4_BulletBase.NativeMethodInfoPtr_get_DamagePower_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, 100665424);
			DLC4_BulletBase.NativeMethodInfoPtr_set_DamagePower_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, 100665425);
			DLC4_BulletBase.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, 100665426);
			DLC4_BulletBase.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, 100665427);
			DLC4_BulletBase.NativeMethodInfoPtr_Initialize_Protected_Void_Int32_Single_Single_DLC4_BossBattleManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, 100665428);
			DLC4_BulletBase.NativeMethodInfoPtr_RecycleIdentityAfterTime_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, 100665429);
			DLC4_BulletBase.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, 100665430);
			DLC4_BulletBase.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, 100665431);
			DLC4_BulletBase.NativeMethodInfoPtr_OnDispose_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, 100665432);
			DLC4_BulletBase.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, 100665433);
			DLC4_BulletBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, 100665434);
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x000C7F50 File Offset: 0x000C6150
		public unsafe BulletTypeIndex BulletIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletBase.NativeMethodInfoPtr_get_BulletIndex_Public_get_BulletTypeIndex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x000C7F8C File Offset: 0x000C618C
		// (set) Token: 0x06000C78 RID: 3192 RVA: 0x000C7FCC File Offset: 0x000C61CC
		public unsafe DLC4_BossBattleManager Dlc4BossBattleManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletBase.NativeMethodInfoPtr_get_Dlc4BossBattleManager_Protected_get_DLC4_BossBattleManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC4_BossBattleManager>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 43501, RefRangeEnd = 43502, XrefRangeStart = 43500, XrefRangeEnd = 43501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletBase.NativeMethodInfoPtr_set_Dlc4BossBattleManager_Private_set_Void_DLC4_BossBattleManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x000C8010 File Offset: 0x000C6210
		public unsafe virtual DLC4_BulletBase.BulletType BulletShooterType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletBase.NativeMethodInfoPtr_get_BulletShooterType_Public_Abstract_Virtual_New_get_BulletType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x000C8058 File Offset: 0x000C6258
		// (set) Token: 0x06000C7B RID: 3195 RVA: 0x000C8094 File Offset: 0x000C6294
		public unsafe float Speed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletBase.NativeMethodInfoPtr_get_Speed_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletBase.NativeMethodInfoPtr_set_Speed_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x000C80D4 File Offset: 0x000C62D4
		// (set) Token: 0x06000C7D RID: 3197 RVA: 0x000C8110 File Offset: 0x000C6310
		public unsafe int DamagePower
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletBase.NativeMethodInfoPtr_get_DamagePower_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletBase.NativeMethodInfoPtr_set_DamagePower_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x000C8150 File Offset: 0x000C6350
		[CallerCount(0)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletBase.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x000C8184 File Offset: 0x000C6384
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletBase.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x000C81B8 File Offset: 0x000C63B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43510, RefRangeEnd = 43512, XrefRangeStart = 43502, XrefRangeEnd = 43510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(int damage, float speed, float duration, DLC4_BossBattleManager dlc4BossBattleManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dlc4BossBattleManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletBase.NativeMethodInfoPtr_Initialize_Protected_Void_Int32_Single_Single_DLC4_BossBattleManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x000C8228 File Offset: 0x000C6428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43512, XrefRangeEnd = 43517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RecycleIdentityAfterTime(float tickTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tickTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletBase.NativeMethodInfoPtr_RecycleIdentityAfterTime_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x000C8274 File Offset: 0x000C6474
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43524, RefRangeEnd = 43526, XrefRangeStart = 43517, XrefRangeEnd = 43524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletBase.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x000C82B0 File Offset: 0x000C64B0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 43537, RefRangeEnd = 43545, XrefRangeStart = 43526, XrefRangeEnd = 43537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletBase.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x000C82E4 File Offset: 0x000C64E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43545, XrefRangeEnd = 43555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletBase.NativeMethodInfoPtr_OnDispose_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x000C8320 File Offset: 0x000C6520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43555, XrefRangeEnd = 43557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletBase.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x000C835C File Offset: 0x000C655C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43417, RefRangeEnd = 43418, XrefRangeStart = 43417, XrefRangeEnd = 43418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_BulletBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x0000890F File Offset: 0x00006B0F
		public DLC4_BulletBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x000C8398 File Offset: 0x000C6598
		// (set) Token: 0x06000C89 RID: 3209 RVA: 0x00008918 File Offset: 0x00006B18
		public unsafe BulletTypeIndex m_BulletIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase.NativeFieldInfoPtr_m_BulletIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase.NativeFieldInfoPtr_m_BulletIndex)) = value;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x000C83C0 File Offset: 0x000C65C0
		// (set) Token: 0x06000C8B RID: 3211 RVA: 0x00008933 File Offset: 0x00006B33
		public VFXPrefab m_HitVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase.NativeFieldInfoPtr_m_HitVFX);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase.NativeFieldInfoPtr_m_HitVFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000C8C RID: 3212 RVA: 0x000C83F0 File Offset: 0x000C65F0
		// (set) Token: 0x06000C8D RID: 3213 RVA: 0x00008961 File Offset: 0x00006B61
		public unsafe Vector2 m_HitVFXOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase.NativeFieldInfoPtr_m_HitVFXOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase.NativeFieldInfoPtr_m_HitVFXOffset)) = value;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x000C8418 File Offset: 0x000C6618
		// (set) Token: 0x06000C8F RID: 3215 RVA: 0x0000897C File Offset: 0x00006B7C
		public unsafe bool HasDisposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase.NativeFieldInfoPtr_HasDisposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase.NativeFieldInfoPtr_HasDisposed)) = value;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x000C8440 File Offset: 0x000C6640
		// (set) Token: 0x06000C91 RID: 3217 RVA: 0x00008997 File Offset: 0x00006B97
		public unsafe Vector3 lastFrameTargetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase.NativeFieldInfoPtr_lastFrameTargetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase.NativeFieldInfoPtr_lastFrameTargetPosition)) = value;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x000C8468 File Offset: 0x000C6668
		// (set) Token: 0x06000C93 RID: 3219 RVA: 0x000089B2 File Offset: 0x00006BB2
		public unsafe Coroutine recycleCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase.NativeFieldInfoPtr_recycleCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase.NativeFieldInfoPtr_recycleCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x000C8498 File Offset: 0x000C6698
		// (set) Token: 0x06000C95 RID: 3221 RVA: 0x000089D1 File Offset: 0x00006BD1
		public unsafe DLC4_BossBattleManager _Dlc4BossBattleManager_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase.NativeFieldInfoPtr__Dlc4BossBattleManager_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_BossBattleManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase.NativeFieldInfoPtr__Dlc4BossBattleManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x000C84C8 File Offset: 0x000C66C8
		// (set) Token: 0x06000C97 RID: 3223 RVA: 0x000089F0 File Offset: 0x00006BF0
		public unsafe float _Speed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase.NativeFieldInfoPtr__Speed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase.NativeFieldInfoPtr__Speed_k__BackingField)) = value;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x000C84F0 File Offset: 0x000C66F0
		// (set) Token: 0x06000C99 RID: 3225 RVA: 0x00008A0B File Offset: 0x00006C0B
		public unsafe int _DamagePower_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase.NativeFieldInfoPtr__DamagePower_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase.NativeFieldInfoPtr__DamagePower_k__BackingField)) = value;
			}
		}

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeFieldInfoPtr_m_BulletIndex;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeFieldInfoPtr_m_HitVFX;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeFieldInfoPtr_m_HitVFXOffset;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeFieldInfoPtr_HasDisposed;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameTargetPosition;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeFieldInfoPtr_recycleCoroutine;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeFieldInfoPtr__Dlc4BossBattleManager_k__BackingField;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeFieldInfoPtr__Speed_k__BackingField;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeFieldInfoPtr__DamagePower_k__BackingField;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_get_BulletIndex_Public_get_BulletTypeIndex_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_get_Dlc4BossBattleManager_Protected_get_DLC4_BossBattleManager_0;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_set_Dlc4BossBattleManager_Private_set_Void_DLC4_BossBattleManager_0;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr_get_BulletShooterType_Public_Abstract_Virtual_New_get_BulletType_0;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr_get_Speed_Protected_get_Single_0;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr_set_Speed_Protected_set_Void_Single_0;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr_get_DamagePower_Protected_get_Int32_0;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeMethodInfoPtr_set_DamagePower_Protected_set_Void_Int32_0;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Void_Int32_Single_Single_DLC4_BossBattleManager_0;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_RecycleIdentityAfterTime_Private_IEnumerator_Single_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeMethodInfoPtr_OnDispose_Protected_Virtual_New_Void_0;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000543 RID: 1347
		public enum BulletType
		{
			// Token: 0x0400588C RID: 22668
			Team,
			// Token: 0x0400588D RID: 22669
			Enemy
		}

		// Token: 0x02000544 RID: 1348
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_BulletBase+<RecycleIdentityAfterTime>d__26")]
		public sealed class _RecycleIdentityAfterTime_d__26 : Il2CppSystem.Object
		{
			// Token: 0x060086F3 RID: 34547 RVA: 0x00259904 File Offset: 0x00257B04
			// Note: this type is marked as 'beforefieldinit'.
			static _RecycleIdentityAfterTime_d__26()
			{
				Il2CppClassPointerStore<DLC4_BulletBase._RecycleIdentityAfterTime_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_BulletBase>.NativeClassPtr, "<RecycleIdentityAfterTime>d__26");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletBase._RecycleIdentityAfterTime_d__26>.NativeClassPtr);
				DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletBase._RecycleIdentityAfterTime_d__26>.NativeClassPtr, "<>1__state");
				DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletBase._RecycleIdentityAfterTime_d__26>.NativeClassPtr, "<>2__current");
				DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeFieldInfoPtr_tickTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletBase._RecycleIdentityAfterTime_d__26>.NativeClassPtr, "tickTime");
				DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletBase._RecycleIdentityAfterTime_d__26>.NativeClassPtr, "<>4__this");
				DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase._RecycleIdentityAfterTime_d__26>.NativeClassPtr, 100665435);
				DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase._RecycleIdentityAfterTime_d__26>.NativeClassPtr, 100665436);
				DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase._RecycleIdentityAfterTime_d__26>.NativeClassPtr, 100665437);
				DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase._RecycleIdentityAfterTime_d__26>.NativeClassPtr, 100665438);
				DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase._RecycleIdentityAfterTime_d__26>.NativeClassPtr, 100665439);
				DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletBase._RecycleIdentityAfterTime_d__26>.NativeClassPtr, 100665440);
			}

			// Token: 0x060086F4 RID: 34548 RVA: 0x002599F8 File Offset: 0x00257BF8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RecycleIdentityAfterTime_d__26(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletBase._RecycleIdentityAfterTime_d__26>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060086F5 RID: 34549 RVA: 0x00259A40 File Offset: 0x00257C40
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060086F6 RID: 34550 RVA: 0x00259A74 File Offset: 0x00257C74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43489, XrefRangeEnd = 43494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002D47 RID: 11591
			// (get) Token: 0x060086F7 RID: 34551 RVA: 0x00259AB0 File Offset: 0x00257CB0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060086F8 RID: 34552 RVA: 0x00259AF0 File Offset: 0x00257CF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43494, XrefRangeEnd = 43500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002D48 RID: 11592
			// (get) Token: 0x060086F9 RID: 34553 RVA: 0x00259B24 File Offset: 0x00257D24
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060086FA RID: 34554 RVA: 0x000489C4 File Offset: 0x00046BC4
			public _RecycleIdentityAfterTime_d__26(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002D43 RID: 11587
			// (get) Token: 0x060086FB RID: 34555 RVA: 0x00259B64 File Offset: 0x00257D64
			// (set) Token: 0x060086FC RID: 34556 RVA: 0x000489CD File Offset: 0x00046BCD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002D44 RID: 11588
			// (get) Token: 0x060086FD RID: 34557 RVA: 0x00259B8C File Offset: 0x00257D8C
			// (set) Token: 0x060086FE RID: 34558 RVA: 0x000489E8 File Offset: 0x00046BE8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D45 RID: 11589
			// (get) Token: 0x060086FF RID: 34559 RVA: 0x00259BBC File Offset: 0x00257DBC
			// (set) Token: 0x06008700 RID: 34560 RVA: 0x00048A07 File Offset: 0x00046C07
			public unsafe float tickTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeFieldInfoPtr_tickTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeFieldInfoPtr_tickTime)) = value;
				}
			}

			// Token: 0x17002D46 RID: 11590
			// (get) Token: 0x06008701 RID: 34561 RVA: 0x00259BE4 File Offset: 0x00257DE4
			// (set) Token: 0x06008702 RID: 34562 RVA: 0x00048A22 File Offset: 0x00046C22
			public unsafe DLC4_BulletBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_BulletBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletBase._RecycleIdentityAfterTime_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400588E RID: 22670
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400588F RID: 22671
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005890 RID: 22672
			private static readonly IntPtr NativeFieldInfoPtr_tickTime;

			// Token: 0x04005891 RID: 22673
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005892 RID: 22674
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005893 RID: 22675
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005894 RID: 22676
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005895 RID: 22677
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005896 RID: 22678
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005897 RID: 22679
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
