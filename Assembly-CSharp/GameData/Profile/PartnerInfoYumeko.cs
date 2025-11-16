using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;
using NightScene.EventUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x0200032E RID: 814
	public sealed class PartnerInfoYumeko : PartnerInfo
	{
		// Token: 0x06005FA2 RID: 24482 RVA: 0x001DCCF0 File Offset: 0x001DAEF0
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerInfoYumeko()
		{
			Il2CppClassPointerStore<PartnerInfoYumeko>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerInfoYumeko");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoYumeko>.NativeClassPtr);
			PartnerInfoYumeko.NativeFieldInfoPtr_throwFood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko>.NativeClassPtr, "throwFood");
			PartnerInfoYumeko.NativeFieldInfoPtr_throwSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko>.NativeClassPtr, "throwSFX");
			PartnerInfoYumeko.NativeFieldInfoPtr_throwDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko>.NativeClassPtr, "throwDuration");
			PartnerInfoYumeko.NativeFieldInfoPtr_launchSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko>.NativeClassPtr, "launchSpeed");
			PartnerInfoYumeko.NativeFieldInfoPtr_launchHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko>.NativeClassPtr, "launchHeight");
			PartnerInfoYumeko.NativeMethodInfoPtr_get_PartnerDeliverType_Public_Virtual_get_DeliverType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko>.NativeClassPtr, 100682942);
			PartnerInfoYumeko.NativeMethodInfoPtr_get_AdditionalDataRequirement_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko>.NativeClassPtr, 100682943);
			PartnerInfoYumeko.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko>.NativeClassPtr, 100682944);
			PartnerInfoYumeko.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko>.NativeClassPtr, 100682945);
			PartnerInfoYumeko.NativeMethodInfoPtr_SpecialLerpParabolic_Private_Static_IEnumerator_Transform_Func_1_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko>.NativeClassPtr, 100682946);
			PartnerInfoYumeko.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko>.NativeClassPtr, 100682947);
			PartnerInfoYumeko.NativeMethodInfoPtr_Method_Internal_Static_Single_byref___c__DisplayClass11_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko>.NativeClassPtr, 100682948);
			PartnerInfoYumeko.NativeMethodInfoPtr_Method_Internal_Static_Vector3_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko>.NativeClassPtr, 100682949);
		}

		// Token: 0x1700210E RID: 8462
		// (get) Token: 0x06005FA3 RID: 24483 RVA: 0x001DCE24 File Offset: 0x001DB024
		public unsafe override PartnerInfoBase.DeliverType PartnerDeliverType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko.NativeMethodInfoPtr_get_PartnerDeliverType_Public_Virtual_get_DeliverType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700210F RID: 8463
		// (get) Token: 0x06005FA4 RID: 24484 RVA: 0x001DCE60 File Offset: 0x001DB060
		public unsafe override int AdditionalDataRequirement
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko.NativeMethodInfoPtr_get_AdditionalDataRequirement_Protected_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005FA5 RID: 24485 RVA: 0x001DCE9C File Offset: 0x001DB09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235973, XrefRangeEnd = 235989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, Il2CppReferenceArray<Il2CppSystem.Object> additionalData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerBase);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerManager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FA6 RID: 24486 RVA: 0x001DCF18 File Offset: 0x001DB118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235989, XrefRangeEnd = 235992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostProcessInfo(StringBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FA7 RID: 24487 RVA: 0x001DCF5C File Offset: 0x001DB15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235992, XrefRangeEnd = 235998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator SpecialLerpParabolic(Transform source, Func<Vector3> targetPosition, float launchHeight, float launchSpeed)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetPosition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref launchHeight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref launchSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko.NativeMethodInfoPtr_SpecialLerpParabolic_Private_Static_IEnumerator_Transform_Func_1_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005FA8 RID: 24488 RVA: 0x001DCFD0 File Offset: 0x001DB1D0
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerInfoYumeko() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoYumeko>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FA9 RID: 24489 RVA: 0x001DD00C File Offset: 0x001DB20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Method_Internal_Static_Single_byref___c__DisplayClass11_0_PDM_0(ref PartnerInfoYumeko.__c__DisplayClass11_0 A_0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko.NativeMethodInfoPtr_Method_Internal_Static_Single_byref___c__DisplayClass11_0_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005FAA RID: 24490 RVA: 0x001DD050 File Offset: 0x001DB250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 17702, RefRangeEnd = 17703, XrefRangeStart = 17702, XrefRangeEnd = 17703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Method_Internal_Static_Vector3_byref___c__DisplayClass11_0_0(ref PartnerInfoYumeko.__c__DisplayClass11_0 A_0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko.NativeMethodInfoPtr_Method_Internal_Static_Vector3_byref___c__DisplayClass11_0_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005FAB RID: 24491 RVA: 0x000340DA File Offset: 0x000322DA
		public PartnerInfoYumeko(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002109 RID: 8457
		// (get) Token: 0x06005FAC RID: 24492 RVA: 0x001DD094 File Offset: 0x001DB294
		// (set) Token: 0x06005FAD RID: 24493 RVA: 0x000340E3 File Offset: 0x000322E3
		public unsafe GameObject throwFood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.NativeFieldInfoPtr_throwFood);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.NativeFieldInfoPtr_throwFood), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700210A RID: 8458
		// (get) Token: 0x06005FAE RID: 24494 RVA: 0x001DD0C4 File Offset: 0x001DB2C4
		// (set) Token: 0x06005FAF RID: 24495 RVA: 0x00034102 File Offset: 0x00032302
		public unsafe AudioClip throwSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.NativeFieldInfoPtr_throwSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.NativeFieldInfoPtr_throwSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700210B RID: 8459
		// (get) Token: 0x06005FB0 RID: 24496 RVA: 0x001DD0F4 File Offset: 0x001DB2F4
		// (set) Token: 0x06005FB1 RID: 24497 RVA: 0x00034121 File Offset: 0x00032321
		public unsafe float throwDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.NativeFieldInfoPtr_throwDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.NativeFieldInfoPtr_throwDuration)) = value;
			}
		}

		// Token: 0x1700210C RID: 8460
		// (get) Token: 0x06005FB2 RID: 24498 RVA: 0x001DD11C File Offset: 0x001DB31C
		// (set) Token: 0x06005FB3 RID: 24499 RVA: 0x0003413C File Offset: 0x0003233C
		public unsafe float launchSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.NativeFieldInfoPtr_launchSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.NativeFieldInfoPtr_launchSpeed)) = value;
			}
		}

		// Token: 0x1700210D RID: 8461
		// (get) Token: 0x06005FB4 RID: 24500 RVA: 0x001DD144 File Offset: 0x001DB344
		// (set) Token: 0x06005FB5 RID: 24501 RVA: 0x00034157 File Offset: 0x00032357
		public unsafe float launchHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.NativeFieldInfoPtr_launchHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.NativeFieldInfoPtr_launchHeight)) = value;
			}
		}

		// Token: 0x04003F3B RID: 16187
		private static readonly IntPtr NativeFieldInfoPtr_throwFood;

		// Token: 0x04003F3C RID: 16188
		private static readonly IntPtr NativeFieldInfoPtr_throwSFX;

		// Token: 0x04003F3D RID: 16189
		private static readonly IntPtr NativeFieldInfoPtr_throwDuration;

		// Token: 0x04003F3E RID: 16190
		private static readonly IntPtr NativeFieldInfoPtr_launchSpeed;

		// Token: 0x04003F3F RID: 16191
		private static readonly IntPtr NativeFieldInfoPtr_launchHeight;

		// Token: 0x04003F40 RID: 16192
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerDeliverType_Public_Virtual_get_DeliverType_0;

		// Token: 0x04003F41 RID: 16193
		private static readonly IntPtr NativeMethodInfoPtr_get_AdditionalDataRequirement_Protected_Virtual_get_Int32_0;

		// Token: 0x04003F42 RID: 16194
		private static readonly IntPtr NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003F43 RID: 16195
		private static readonly IntPtr NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0;

		// Token: 0x04003F44 RID: 16196
		private static readonly IntPtr NativeMethodInfoPtr_SpecialLerpParabolic_Private_Static_IEnumerator_Transform_Func_1_Vector3_Single_Single_0;

		// Token: 0x04003F45 RID: 16197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003F46 RID: 16198
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_byref___c__DisplayClass11_0_PDM_0;

		// Token: 0x04003F47 RID: 16199
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Vector3_byref___c__DisplayClass11_0_0;

		// Token: 0x02000D61 RID: 3425
		[ObfuscatedName("GameData.Profile.PartnerInfoYumeko+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F53B RID: 62779 RVA: 0x0039EFD0 File Offset: 0x0039D1D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoYumeko>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0>.NativeClassPtr);
				PartnerInfoYumeko.__c__DisplayClass9_0.NativeFieldInfoPtr_partnerManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0>.NativeClassPtr, "partnerManager");
				PartnerInfoYumeko.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				PartnerInfoYumeko.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0>.NativeClassPtr, 100682950);
				PartnerInfoYumeko.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Coroutine_Sprite_Vector3_Vector3_Transform_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0>.NativeClassPtr, 100682951);
				PartnerInfoYumeko.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Sprite_Vector3_Vector3_Transform_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0>.NativeClassPtr, 100682952);
			}

			// Token: 0x0600F53C RID: 62780 RVA: 0x0039F060 File Offset: 0x0039D260
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F53D RID: 62781 RVA: 0x0039F09C File Offset: 0x0039D29C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235933, XrefRangeEnd = 235942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Coroutine Method_Internal_Coroutine_Sprite_Vector3_Vector3_Transform_PDM_0(Sprite sprite, Vector3 target, Vector3 position, Transform effectField)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(effectField);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Coroutine_Sprite_Vector3_Vector3_Transform_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
			}

			// Token: 0x0600F53E RID: 62782 RVA: 0x0039F11C File Offset: 0x0039D31C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235942, XrefRangeEnd = 235949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Sprite_Vector3_Vector3_Transform_PDM_0(Sprite sprite, Vector3 target, Vector3 position, Transform effectField)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(effectField);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Sprite_Vector3_Vector3_Transform_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F53F RID: 62783 RVA: 0x00083B9C File Offset: 0x00081D9C
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FB9 RID: 20409
			// (get) Token: 0x0600F540 RID: 62784 RVA: 0x0039F19C File Offset: 0x0039D39C
			// (set) Token: 0x0600F541 RID: 62785 RVA: 0x00083BA5 File Offset: 0x00081DA5
			public unsafe PartnerManager partnerManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_0.NativeFieldInfoPtr_partnerManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_0.NativeFieldInfoPtr_partnerManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FBA RID: 20410
			// (get) Token: 0x0600F542 RID: 62786 RVA: 0x0039F1CC File Offset: 0x0039D3CC
			// (set) Token: 0x0600F543 RID: 62787 RVA: 0x00083BC4 File Offset: 0x00081DC4
			public unsafe PartnerInfoYumeko __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoYumeko>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C2B RID: 39979
			private static readonly IntPtr NativeFieldInfoPtr_partnerManager;

			// Token: 0x04009C2C RID: 39980
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009C2D RID: 39981
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C2E RID: 39982
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Coroutine_Sprite_Vector3_Vector3_Transform_PDM_0;

			// Token: 0x04009C2F RID: 39983
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Sprite_Vector3_Vector3_Transform_PDM_0;

			// Token: 0x0200109C RID: 4252
			[ObfuscatedName("GameData.Profile.PartnerInfoYumeko+<>c__DisplayClass9_0+<<OnPartnerLoad>g__Throw|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique : Il2CppSystem.Object
			{
				// Token: 0x060121C2 RID: 74178 RVA: 0x00421F48 File Offset: 0x00420148
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique()
				{
					Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0>.NativeClassPtr, "<<OnPartnerLoad>g__Throw|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr);
					PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, "<>1__state");
					PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, "<>2__current");
					PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, "sprite");
					PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, "target");
					PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, "<>4__this");
					PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_effectField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, "effectField");
					PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, "position");
					PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr__sellableObject_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, "<sellableObject>5__2");
					PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, 100682953);
					PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, 100682954);
					PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, 100682955);
					PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, 100682956);
					PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, 100682957);
					PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr, 100682958);
				}

				// Token: 0x060121C3 RID: 74179 RVA: 0x0042208C File Offset: 0x0042028C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060121C4 RID: 74180 RVA: 0x004220D4 File Offset: 0x004202D4
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060121C5 RID: 74181 RVA: 0x00422108 File Offset: 0x00420308
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235885, XrefRangeEnd = 235927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E9C RID: 24220
				// (get) Token: 0x060121C6 RID: 74182 RVA: 0x00422144 File Offset: 0x00420344
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060121C7 RID: 74183 RVA: 0x00422184 File Offset: 0x00420384
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235927, XrefRangeEnd = 235933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E9D RID: 24221
				// (get) Token: 0x060121C8 RID: 74184 RVA: 0x004221B8 File Offset: 0x004203B8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060121C9 RID: 74185 RVA: 0x0009D59B File Offset: 0x0009B79B
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E94 RID: 24212
				// (get) Token: 0x060121CA RID: 74186 RVA: 0x004221F8 File Offset: 0x004203F8
				// (set) Token: 0x060121CB RID: 74187 RVA: 0x0009D5A4 File Offset: 0x0009B7A4
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E95 RID: 24213
				// (get) Token: 0x060121CC RID: 74188 RVA: 0x00422220 File Offset: 0x00420420
				// (set) Token: 0x060121CD RID: 74189 RVA: 0x0009D5BF File Offset: 0x0009B7BF
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E96 RID: 24214
				// (get) Token: 0x060121CE RID: 74190 RVA: 0x00422250 File Offset: 0x00420450
				// (set) Token: 0x060121CF RID: 74191 RVA: 0x0009D5DE File Offset: 0x0009B7DE
				public unsafe Sprite sprite
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_sprite);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E97 RID: 24215
				// (get) Token: 0x060121D0 RID: 74192 RVA: 0x00422280 File Offset: 0x00420480
				// (set) Token: 0x060121D1 RID: 74193 RVA: 0x0009D5FD File Offset: 0x0009B7FD
				public unsafe Vector3 target
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_target);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_target)) = value;
					}
				}

				// Token: 0x17005E98 RID: 24216
				// (get) Token: 0x060121D2 RID: 74194 RVA: 0x004222A8 File Offset: 0x004204A8
				// (set) Token: 0x060121D3 RID: 74195 RVA: 0x0009D618 File Offset: 0x0009B818
				public unsafe PartnerInfoYumeko.__c__DisplayClass9_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoYumeko.__c__DisplayClass9_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E99 RID: 24217
				// (get) Token: 0x060121D4 RID: 74196 RVA: 0x004222D8 File Offset: 0x004204D8
				// (set) Token: 0x060121D5 RID: 74197 RVA: 0x0009D637 File Offset: 0x0009B837
				public unsafe Transform effectField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_effectField);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_effectField), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E9A RID: 24218
				// (get) Token: 0x060121D6 RID: 74198 RVA: 0x00422308 File Offset: 0x00420508
				// (set) Token: 0x060121D7 RID: 74199 RVA: 0x0009D656 File Offset: 0x0009B856
				public unsafe Vector3 position
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_position);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr_position)) = value;
					}
				}

				// Token: 0x17005E9B RID: 24219
				// (get) Token: 0x060121D8 RID: 74200 RVA: 0x00422330 File Offset: 0x00420530
				// (set) Token: 0x060121D9 RID: 74201 RVA: 0x0009D671 File Offset: 0x0009B871
				public unsafe GameObject _sellableObject_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr__sellableObject_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpspVetaTrefpoVeUnique.NativeFieldInfoPtr__sellableObject_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B77D RID: 46973
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B77E RID: 46974
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B77F RID: 46975
				private static readonly IntPtr NativeFieldInfoPtr_sprite;

				// Token: 0x0400B780 RID: 46976
				private static readonly IntPtr NativeFieldInfoPtr_target;

				// Token: 0x0400B781 RID: 46977
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B782 RID: 46978
				private static readonly IntPtr NativeFieldInfoPtr_effectField;

				// Token: 0x0400B783 RID: 46979
				private static readonly IntPtr NativeFieldInfoPtr_position;

				// Token: 0x0400B784 RID: 46980
				private static readonly IntPtr NativeFieldInfoPtr__sellableObject_5__2;

				// Token: 0x0400B785 RID: 46981
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B786 RID: 46982
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B787 RID: 46983
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B788 RID: 46984
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B789 RID: 46985
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B78A RID: 46986
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000D62 RID: 3426
		[ObfuscatedName("GameData.Profile.PartnerInfoYumeko+<>c__DisplayClass9_1")]
		public sealed class __c__DisplayClass9_1 : Il2CppSystem.Object
		{
			// Token: 0x0600F544 RID: 62788 RVA: 0x0039F1FC File Offset: 0x0039D3FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_1()
			{
				Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoYumeko>.NativeClassPtr, "<>c__DisplayClass9_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_1>.NativeClassPtr);
				PartnerInfoYumeko.__c__DisplayClass9_1.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_1>.NativeClassPtr, "sprite");
				PartnerInfoYumeko.__c__DisplayClass9_1.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_1>.NativeClassPtr, "target");
				PartnerInfoYumeko.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_1>.NativeClassPtr, 100682959);
				PartnerInfoYumeko.__c__DisplayClass9_1.NativeMethodInfoPtr__OnPartnerLoad_b__2_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_1>.NativeClassPtr, 100682960);
				PartnerInfoYumeko.__c__DisplayClass9_1.NativeMethodInfoPtr__OnPartnerLoad_b__3_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_1>.NativeClassPtr, 100682961);
			}

			// Token: 0x0600F545 RID: 62789 RVA: 0x0039F28C File Offset: 0x0039D48C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass9_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F546 RID: 62790 RVA: 0x0039F2C8 File Offset: 0x0039D4C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPartnerLoad_b__2(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko.__c__DisplayClass9_1.NativeMethodInfoPtr__OnPartnerLoad_b__2_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F547 RID: 62791 RVA: 0x0039F30C File Offset: 0x0039D50C
			[CallerCount(0)]
			public unsafe Vector3 _OnPartnerLoad_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko.__c__DisplayClass9_1.NativeMethodInfoPtr__OnPartnerLoad_b__3_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F548 RID: 62792 RVA: 0x00083BE3 File Offset: 0x00081DE3
			public __c__DisplayClass9_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FBB RID: 20411
			// (get) Token: 0x0600F549 RID: 62793 RVA: 0x0039F348 File Offset: 0x0039D548
			// (set) Token: 0x0600F54A RID: 62794 RVA: 0x00083BEC File Offset: 0x00081DEC
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_1.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_1.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FBC RID: 20412
			// (get) Token: 0x0600F54B RID: 62795 RVA: 0x0039F378 File Offset: 0x0039D578
			// (set) Token: 0x0600F54C RID: 62796 RVA: 0x00083C0B File Offset: 0x00081E0B
			public unsafe Vector3 target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_1.NativeFieldInfoPtr_target);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass9_1.NativeFieldInfoPtr_target)) = value;
				}
			}

			// Token: 0x04009C30 RID: 39984
			private static readonly IntPtr NativeFieldInfoPtr_sprite;

			// Token: 0x04009C31 RID: 39985
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04009C32 RID: 39986
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C33 RID: 39987
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerLoad_b__2_Internal_Void_SpriteRenderer_0;

			// Token: 0x04009C34 RID: 39988
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerLoad_b__3_Internal_Vector3_0;
		}

		// Token: 0x02000D63 RID: 3427
		[ObfuscatedName("GameData.Profile.PartnerInfoYumeko+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : ValueType
		{
			// Token: 0x0600F54D RID: 62797 RVA: 0x0039F3A0 File Offset: 0x0039D5A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoYumeko>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass11_0>.NativeClassPtr);
				PartnerInfoYumeko.__c__DisplayClass11_0.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass11_0>.NativeClassPtr, "start");
				PartnerInfoYumeko.__c__DisplayClass11_0.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass11_0>.NativeClassPtr, "targetPosition");
				PartnerInfoYumeko.__c__DisplayClass11_0.NativeFieldInfoPtr_launchHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass11_0>.NativeClassPtr, "launchHeight");
			}

			// Token: 0x0600F54E RID: 62798 RVA: 0x00083C26 File Offset: 0x00081E26
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600F54F RID: 62799 RVA: 0x00083C2F File Offset: 0x00081E2F
			public __c__DisplayClass11_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass11_0>.NativeClassPtr))
			{
			}

			// Token: 0x17004FBD RID: 20413
			// (get) Token: 0x0600F550 RID: 62800 RVA: 0x0039F408 File Offset: 0x0039D608
			// (set) Token: 0x0600F551 RID: 62801 RVA: 0x00083C41 File Offset: 0x00081E41
			public unsafe Vector3 start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass11_0.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass11_0.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x17004FBE RID: 20414
			// (get) Token: 0x0600F552 RID: 62802 RVA: 0x0039F430 File Offset: 0x0039D630
			// (set) Token: 0x0600F553 RID: 62803 RVA: 0x00083C5C File Offset: 0x00081E5C
			public unsafe Func<Vector3> targetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass11_0.NativeFieldInfoPtr_targetPosition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass11_0.NativeFieldInfoPtr_targetPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FBF RID: 20415
			// (get) Token: 0x0600F554 RID: 62804 RVA: 0x0039F460 File Offset: 0x0039D660
			// (set) Token: 0x0600F555 RID: 62805 RVA: 0x00083C7B File Offset: 0x00081E7B
			public unsafe float launchHeight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass11_0.NativeFieldInfoPtr_launchHeight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko.__c__DisplayClass11_0.NativeFieldInfoPtr_launchHeight)) = value;
				}
			}

			// Token: 0x04009C35 RID: 39989
			private static readonly IntPtr NativeFieldInfoPtr_start;

			// Token: 0x04009C36 RID: 39990
			private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

			// Token: 0x04009C37 RID: 39991
			private static readonly IntPtr NativeFieldInfoPtr_launchHeight;
		}

		// Token: 0x02000D64 RID: 3428
		[ObfuscatedName("GameData.Profile.PartnerInfoYumeko+<SpecialLerpParabolic>d__11")]
		public sealed class _SpecialLerpParabolic_d__11 : Il2CppSystem.Object
		{
			// Token: 0x0600F556 RID: 62806 RVA: 0x0039F488 File Offset: 0x0039D688
			// Note: this type is marked as 'beforefieldinit'.
			static _SpecialLerpParabolic_d__11()
			{
				Il2CppClassPointerStore<PartnerInfoYumeko._SpecialLerpParabolic_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoYumeko>.NativeClassPtr, "<SpecialLerpParabolic>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoYumeko._SpecialLerpParabolic_d__11>.NativeClassPtr);
				PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko._SpecialLerpParabolic_d__11>.NativeClassPtr, "<>1__state");
				PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko._SpecialLerpParabolic_d__11>.NativeClassPtr, "<>2__current");
				PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko._SpecialLerpParabolic_d__11>.NativeClassPtr, "targetPosition");
				PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr_launchHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko._SpecialLerpParabolic_d__11>.NativeClassPtr, "launchHeight");
				PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko._SpecialLerpParabolic_d__11>.NativeClassPtr, "source");
				PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr_launchSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko._SpecialLerpParabolic_d__11>.NativeClassPtr, "launchSpeed");
				PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko._SpecialLerpParabolic_d__11>.NativeClassPtr, "<>8__1");
				PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr__knife_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko._SpecialLerpParabolic_d__11>.NativeClassPtr, "<knife>5__2");
				PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr__progress_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYumeko._SpecialLerpParabolic_d__11>.NativeClassPtr, "<progress>5__3");
				PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko._SpecialLerpParabolic_d__11>.NativeClassPtr, 100682962);
				PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko._SpecialLerpParabolic_d__11>.NativeClassPtr, 100682963);
				PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko._SpecialLerpParabolic_d__11>.NativeClassPtr, 100682964);
				PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko._SpecialLerpParabolic_d__11>.NativeClassPtr, 100682965);
				PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko._SpecialLerpParabolic_d__11>.NativeClassPtr, 100682966);
				PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYumeko._SpecialLerpParabolic_d__11>.NativeClassPtr, 100682967);
			}

			// Token: 0x0600F557 RID: 62807 RVA: 0x0039F5E0 File Offset: 0x0039D7E0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SpecialLerpParabolic_d__11(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoYumeko._SpecialLerpParabolic_d__11>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F558 RID: 62808 RVA: 0x0039F628 File Offset: 0x0039D828
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F559 RID: 62809 RVA: 0x0039F65C File Offset: 0x0039D85C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235949, XrefRangeEnd = 235967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004FC9 RID: 20425
			// (get) Token: 0x0600F55A RID: 62810 RVA: 0x0039F698 File Offset: 0x0039D898
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F55B RID: 62811 RVA: 0x0039F6D8 File Offset: 0x0039D8D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235967, XrefRangeEnd = 235973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004FCA RID: 20426
			// (get) Token: 0x0600F55C RID: 62812 RVA: 0x0039F70C File Offset: 0x0039D90C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F55D RID: 62813 RVA: 0x00083C96 File Offset: 0x00081E96
			public _SpecialLerpParabolic_d__11(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FC0 RID: 20416
			// (get) Token: 0x0600F55E RID: 62814 RVA: 0x0039F74C File Offset: 0x0039D94C
			// (set) Token: 0x0600F55F RID: 62815 RVA: 0x00083C9F File Offset: 0x00081E9F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004FC1 RID: 20417
			// (get) Token: 0x0600F560 RID: 62816 RVA: 0x0039F774 File Offset: 0x0039D974
			// (set) Token: 0x0600F561 RID: 62817 RVA: 0x00083CBA File Offset: 0x00081EBA
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FC2 RID: 20418
			// (get) Token: 0x0600F562 RID: 62818 RVA: 0x0039F7A4 File Offset: 0x0039D9A4
			// (set) Token: 0x0600F563 RID: 62819 RVA: 0x00083CD9 File Offset: 0x00081ED9
			public unsafe Func<Vector3> targetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr_targetPosition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr_targetPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FC3 RID: 20419
			// (get) Token: 0x0600F564 RID: 62820 RVA: 0x0039F7D4 File Offset: 0x0039D9D4
			// (set) Token: 0x0600F565 RID: 62821 RVA: 0x00083CF8 File Offset: 0x00081EF8
			public unsafe float launchHeight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr_launchHeight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr_launchHeight)) = value;
				}
			}

			// Token: 0x17004FC4 RID: 20420
			// (get) Token: 0x0600F566 RID: 62822 RVA: 0x0039F7FC File Offset: 0x0039D9FC
			// (set) Token: 0x0600F567 RID: 62823 RVA: 0x00083D13 File Offset: 0x00081F13
			public unsafe Transform source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FC5 RID: 20421
			// (get) Token: 0x0600F568 RID: 62824 RVA: 0x0039F82C File Offset: 0x0039DA2C
			// (set) Token: 0x0600F569 RID: 62825 RVA: 0x00083D32 File Offset: 0x00081F32
			public unsafe float launchSpeed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr_launchSpeed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr_launchSpeed)) = value;
				}
			}

			// Token: 0x17004FC6 RID: 20422
			// (get) Token: 0x0600F56A RID: 62826 RVA: 0x0039F854 File Offset: 0x0039DA54
			// (set) Token: 0x0600F56B RID: 62827 RVA: 0x00083D4D File Offset: 0x00081F4D
			public PartnerInfoYumeko.__c__DisplayClass11_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr___8__1);
					return new PartnerInfoYumeko.__c__DisplayClass11_0(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass11_0>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr___8__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PartnerInfoYumeko.__c__DisplayClass11_0>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004FC7 RID: 20423
			// (get) Token: 0x0600F56C RID: 62828 RVA: 0x0039F884 File Offset: 0x0039DA84
			// (set) Token: 0x0600F56D RID: 62829 RVA: 0x00083D7B File Offset: 0x00081F7B
			public unsafe Transform _knife_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr__knife_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr__knife_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FC8 RID: 20424
			// (get) Token: 0x0600F56E RID: 62830 RVA: 0x0039F8B4 File Offset: 0x0039DAB4
			// (set) Token: 0x0600F56F RID: 62831 RVA: 0x00083D9A File Offset: 0x00081F9A
			public unsafe float _progress_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr__progress_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYumeko._SpecialLerpParabolic_d__11.NativeFieldInfoPtr__progress_5__3)) = value;
				}
			}

			// Token: 0x04009C38 RID: 39992
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009C39 RID: 39993
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009C3A RID: 39994
			private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

			// Token: 0x04009C3B RID: 39995
			private static readonly IntPtr NativeFieldInfoPtr_launchHeight;

			// Token: 0x04009C3C RID: 39996
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04009C3D RID: 39997
			private static readonly IntPtr NativeFieldInfoPtr_launchSpeed;

			// Token: 0x04009C3E RID: 39998
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04009C3F RID: 39999
			private static readonly IntPtr NativeFieldInfoPtr__knife_5__2;

			// Token: 0x04009C40 RID: 40000
			private static readonly IntPtr NativeFieldInfoPtr__progress_5__3;

			// Token: 0x04009C41 RID: 40001
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009C42 RID: 40002
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009C43 RID: 40003
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009C44 RID: 40004
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009C45 RID: 40005
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009C46 RID: 40006
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
