using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace NightScene.GuestManagementUtility
{
	// Token: 0x020001A9 RID: 425
	public class GuestTableDisplayer : MonoBehaviour
	{
		// Token: 0x060030A6 RID: 12454 RVA: 0x00141994 File Offset: 0x0013FB94
		// Note: this type is marked as 'beforefieldinit'.
		static GuestTableDisplayer()
		{
			Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.GuestManagementUtility", "GuestTableDisplayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr);
			GuestTableDisplayer.NativeFieldInfoPtr_RENDERER_INITIAL_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, "RENDERER_INITIAL_Y");
			GuestTableDisplayer.NativeFieldInfoPtr_foodRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, "foodRenderer");
			GuestTableDisplayer.NativeFieldInfoPtr_beverageRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, "beverageRenderer");
			GuestTableDisplayer.NativeFieldInfoPtr_moodRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, "moodRenderer");
			GuestTableDisplayer.NativeFieldInfoPtr_moodBarRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, "moodBarRenderer");
			GuestTableDisplayer.NativeFieldInfoPtr_moodRendererToggleDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, "moodRendererToggleDuration");
			GuestTableDisplayer.NativeFieldInfoPtr_deskCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, "deskCode");
			GuestTableDisplayer.NativeFieldInfoPtr_deskCodeDisplayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, "deskCodeDisplayer");
			GuestTableDisplayer.NativeFieldInfoPtr_allProgressBars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, "allProgressBars");
			GuestTableDisplayer.NativeFieldInfoPtr_patientProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, "patientProgress");
			GuestTableDisplayer.NativeFieldInfoPtr_m_MoodSizeMinMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, "m_MoodSizeMinMax");
			GuestTableDisplayer.NativeFieldInfoPtr_m_PatientSizeMinMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, "m_PatientSizeMinMax");
			GuestTableDisplayer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, 100672058);
			GuestTableDisplayer.NativeMethodInfoPtr_ShowMood_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, 100672059);
			GuestTableDisplayer.NativeMethodInfoPtr_SetMoodProgress_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, 100672060);
			GuestTableDisplayer.NativeMethodInfoPtr_UpdatePatient_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, 100672061);
			GuestTableDisplayer.NativeMethodInfoPtr_DisablePatient_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, 100672062);
			GuestTableDisplayer.NativeMethodInfoPtr_Initialize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, 100672063);
			GuestTableDisplayer.NativeMethodInfoPtr_ResetValue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, 100672064);
			GuestTableDisplayer.NativeMethodInfoPtr_CleanDesk_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, 100672065);
			GuestTableDisplayer.NativeMethodInfoPtr_SetFoodVisual_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, 100672066);
			GuestTableDisplayer.NativeMethodInfoPtr_SetBeverageVisual_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, 100672067);
			GuestTableDisplayer.NativeMethodInfoPtr_SetValue_Private_Void_Sprite_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, 100672068);
			GuestTableDisplayer.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, 100672069);
			GuestTableDisplayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, 100672070);
			GuestTableDisplayer.NativeMethodInfoPtr_Method_Internal_Static_Void_SpriteRenderer_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr, 100672071);
		}

		// Token: 0x060030A7 RID: 12455 RVA: 0x00141BCC File Offset: 0x0013FDCC
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestTableDisplayer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030A8 RID: 12456 RVA: 0x00141C00 File Offset: 0x0013FE00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110049, RefRangeEnd = 110050, XrefRangeStart = 110036, XrefRangeEnd = 110049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowMood()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestTableDisplayer.NativeMethodInfoPtr_ShowMood_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030A9 RID: 12457 RVA: 0x00141C34 File Offset: 0x0013FE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110050, XrefRangeEnd = 110057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMoodProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestTableDisplayer.NativeMethodInfoPtr_SetMoodProgress_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030AA RID: 12458 RVA: 0x00141C74 File Offset: 0x0013FE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110057, XrefRangeEnd = 110066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePatient(int progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestTableDisplayer.NativeMethodInfoPtr_UpdatePatient_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x00141CB4 File Offset: 0x0013FEB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110068, RefRangeEnd = 110069, XrefRangeStart = 110066, XrefRangeEnd = 110068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisablePatient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestTableDisplayer.NativeMethodInfoPtr_DisablePatient_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x00141CE8 File Offset: 0x0013FEE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110072, RefRangeEnd = 110073, XrefRangeStart = 110069, XrefRangeEnd = 110072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestTableDisplayer.NativeMethodInfoPtr_Initialize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030AD RID: 12461 RVA: 0x00141D28 File Offset: 0x0013FF28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110083, RefRangeEnd = 110084, XrefRangeStart = 110073, XrefRangeEnd = 110083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestTableDisplayer.NativeMethodInfoPtr_ResetValue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x00141D5C File Offset: 0x0013FF5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110086, RefRangeEnd = 110087, XrefRangeStart = 110084, XrefRangeEnd = 110086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanDesk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestTableDisplayer.NativeMethodInfoPtr_CleanDesk_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x00141D90 File Offset: 0x0013FF90
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 110091, RefRangeEnd = 110095, XrefRangeStart = 110087, XrefRangeEnd = 110091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFoodVisual(Sprite food)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(food);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestTableDisplayer.NativeMethodInfoPtr_SetFoodVisual_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x00141DD4 File Offset: 0x0013FFD4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 110099, RefRangeEnd = 110103, XrefRangeStart = 110095, XrefRangeEnd = 110099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBeverageVisual(Sprite beverage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beverage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestTableDisplayer.NativeMethodInfoPtr_SetBeverageVisual_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x00141E18 File Offset: 0x00140018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110103, XrefRangeEnd = 110105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(Sprite food, Sprite beverage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(food);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beverage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestTableDisplayer.NativeMethodInfoPtr_SetValue_Private_Void_Sprite_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x00141E6C File Offset: 0x0014006C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110105, XrefRangeEnd = 110113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuestTableDisplayer.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x00141EA8 File Offset: 0x001400A8
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuestTableDisplayer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestTableDisplayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestTableDisplayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x00141EE4 File Offset: 0x001400E4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 110137, RefRangeEnd = 110149, XrefRangeStart = 110113, XrefRangeEnd = 110137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_SpriteRenderer_Sprite_0(SpriteRenderer renderer, Sprite target)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestTableDisplayer.NativeMethodInfoPtr_Method_Internal_Static_Void_SpriteRenderer_Sprite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x0001BAF0 File Offset: 0x00019CF0
		public GuestTableDisplayer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x060030B6 RID: 12470 RVA: 0x00141F2C File Offset: 0x0014012C
		// (set) Token: 0x060030B7 RID: 12471 RVA: 0x0001BAF9 File Offset: 0x00019CF9
		public unsafe static float RENDERER_INITIAL_Y
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GuestTableDisplayer.NativeFieldInfoPtr_RENDERER_INITIAL_Y, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestTableDisplayer.NativeFieldInfoPtr_RENDERER_INITIAL_Y, (void*)(&value));
			}
		}

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x060030B8 RID: 12472 RVA: 0x00141F48 File Offset: 0x00140148
		// (set) Token: 0x060030B9 RID: 12473 RVA: 0x0001BB07 File Offset: 0x00019D07
		public unsafe SpriteRenderer foodRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_foodRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_foodRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x060030BA RID: 12474 RVA: 0x00141F78 File Offset: 0x00140178
		// (set) Token: 0x060030BB RID: 12475 RVA: 0x0001BB26 File Offset: 0x00019D26
		public unsafe SpriteRenderer beverageRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_beverageRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_beverageRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x060030BC RID: 12476 RVA: 0x00141FA8 File Offset: 0x001401A8
		// (set) Token: 0x060030BD RID: 12477 RVA: 0x0001BB45 File Offset: 0x00019D45
		public unsafe SpriteRenderer moodRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_moodRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_moodRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x060030BE RID: 12478 RVA: 0x00141FD8 File Offset: 0x001401D8
		// (set) Token: 0x060030BF RID: 12479 RVA: 0x0001BB64 File Offset: 0x00019D64
		public unsafe SpriteRenderer moodBarRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_moodBarRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_moodBarRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x060030C0 RID: 12480 RVA: 0x00142008 File Offset: 0x00140208
		// (set) Token: 0x060030C1 RID: 12481 RVA: 0x0001BB83 File Offset: 0x00019D83
		public unsafe float moodRendererToggleDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_moodRendererToggleDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_moodRendererToggleDuration)) = value;
			}
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x060030C2 RID: 12482 RVA: 0x00142030 File Offset: 0x00140230
		// (set) Token: 0x060030C3 RID: 12483 RVA: 0x0001BB9E File Offset: 0x00019D9E
		public unsafe TextMeshPro deskCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_deskCode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_deskCode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x060030C4 RID: 12484 RVA: 0x00142060 File Offset: 0x00140260
		// (set) Token: 0x060030C5 RID: 12485 RVA: 0x0001BBBD File Offset: 0x00019DBD
		public unsafe GameObject deskCodeDisplayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_deskCodeDisplayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_deskCodeDisplayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x060030C6 RID: 12486 RVA: 0x00142090 File Offset: 0x00140290
		// (set) Token: 0x060030C7 RID: 12487 RVA: 0x0001BBDC File Offset: 0x00019DDC
		public unsafe Il2CppReferenceArray<Sprite> allProgressBars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_allProgressBars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_allProgressBars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x060030C8 RID: 12488 RVA: 0x001420C0 File Offset: 0x001402C0
		// (set) Token: 0x060030C9 RID: 12489 RVA: 0x0001BBFB File Offset: 0x00019DFB
		public unsafe SpriteRenderer patientProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_patientProgress);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_patientProgress), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x060030CA RID: 12490 RVA: 0x001420F0 File Offset: 0x001402F0
		// (set) Token: 0x060030CB RID: 12491 RVA: 0x0001BC1A File Offset: 0x00019E1A
		public unsafe Vector2 m_MoodSizeMinMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_m_MoodSizeMinMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_m_MoodSizeMinMax)) = value;
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x060030CC RID: 12492 RVA: 0x00142118 File Offset: 0x00140318
		// (set) Token: 0x060030CD RID: 12493 RVA: 0x0001BC35 File Offset: 0x00019E35
		public unsafe Vector2 m_PatientSizeMinMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_m_PatientSizeMinMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestTableDisplayer.NativeFieldInfoPtr_m_PatientSizeMinMax)) = value;
			}
		}

		// Token: 0x04002081 RID: 8321
		private static readonly IntPtr NativeFieldInfoPtr_RENDERER_INITIAL_Y;

		// Token: 0x04002082 RID: 8322
		private static readonly IntPtr NativeFieldInfoPtr_foodRenderer;

		// Token: 0x04002083 RID: 8323
		private static readonly IntPtr NativeFieldInfoPtr_beverageRenderer;

		// Token: 0x04002084 RID: 8324
		private static readonly IntPtr NativeFieldInfoPtr_moodRenderer;

		// Token: 0x04002085 RID: 8325
		private static readonly IntPtr NativeFieldInfoPtr_moodBarRenderer;

		// Token: 0x04002086 RID: 8326
		private static readonly IntPtr NativeFieldInfoPtr_moodRendererToggleDuration;

		// Token: 0x04002087 RID: 8327
		private static readonly IntPtr NativeFieldInfoPtr_deskCode;

		// Token: 0x04002088 RID: 8328
		private static readonly IntPtr NativeFieldInfoPtr_deskCodeDisplayer;

		// Token: 0x04002089 RID: 8329
		private static readonly IntPtr NativeFieldInfoPtr_allProgressBars;

		// Token: 0x0400208A RID: 8330
		private static readonly IntPtr NativeFieldInfoPtr_patientProgress;

		// Token: 0x0400208B RID: 8331
		private static readonly IntPtr NativeFieldInfoPtr_m_MoodSizeMinMax;

		// Token: 0x0400208C RID: 8332
		private static readonly IntPtr NativeFieldInfoPtr_m_PatientSizeMinMax;

		// Token: 0x0400208D RID: 8333
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400208E RID: 8334
		private static readonly IntPtr NativeMethodInfoPtr_ShowMood_Public_Void_0;

		// Token: 0x0400208F RID: 8335
		private static readonly IntPtr NativeMethodInfoPtr_SetMoodProgress_Public_Void_Single_0;

		// Token: 0x04002090 RID: 8336
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePatient_Public_Void_Int32_0;

		// Token: 0x04002091 RID: 8337
		private static readonly IntPtr NativeMethodInfoPtr_DisablePatient_Public_Void_0;

		// Token: 0x04002092 RID: 8338
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_0;

		// Token: 0x04002093 RID: 8339
		private static readonly IntPtr NativeMethodInfoPtr_ResetValue_Public_Void_0;

		// Token: 0x04002094 RID: 8340
		private static readonly IntPtr NativeMethodInfoPtr_CleanDesk_Public_Void_0;

		// Token: 0x04002095 RID: 8341
		private static readonly IntPtr NativeMethodInfoPtr_SetFoodVisual_Public_Void_Sprite_0;

		// Token: 0x04002096 RID: 8342
		private static readonly IntPtr NativeMethodInfoPtr_SetBeverageVisual_Public_Void_Sprite_0;

		// Token: 0x04002097 RID: 8343
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Private_Void_Sprite_Sprite_0;

		// Token: 0x04002098 RID: 8344
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04002099 RID: 8345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400209A RID: 8346
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_SpriteRenderer_Sprite_0;
	}
}
