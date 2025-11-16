using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace DayScene.UI
{
	// Token: 0x020000BD RID: 189
	public class DaySceneClosetSubPannel : UISubPanel<DaySceneClosetPannel>
	{
		// Token: 0x0600150E RID: 5390 RVA: 0x000E572C File Offset: 0x000E392C
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneClosetSubPannel()
		{
			Il2CppClassPointerStore<DaySceneClosetSubPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DaySceneClosetSubPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneClosetSubPannel>.NativeClassPtr);
			DaySceneClosetSubPannel.NativeFieldInfoPtr_SubmitText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetSubPannel>.NativeClassPtr, "SubmitText");
			DaySceneClosetSubPannel.NativeFieldInfoPtr_Check = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetSubPannel>.NativeClassPtr, "Check");
			DaySceneClosetSubPannel.NativeFieldInfoPtr_ChangeClothesBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetSubPannel>.NativeClassPtr, "ChangeClothesBtn");
			DaySceneClosetSubPannel.NativeFieldInfoPtr_UseAtNightSubmitBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetSubPannel>.NativeClassPtr, "UseAtNightSubmitBtn");
			DaySceneClosetSubPannel.NativeFieldInfoPtr_UseIzakayaSkinSubmitBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetSubPannel>.NativeClassPtr, "UseIzakayaSkinSubmitBtn");
			DaySceneClosetSubPannel.NativeFieldInfoPtr_UseAtNightSubmitBtnGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetSubPannel>.NativeClassPtr, "UseAtNightSubmitBtnGameObject");
			DaySceneClosetSubPannel.NativeFieldInfoPtr_UseIzakayaSkinSubmitBtnGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetSubPannel>.NativeClassPtr, "UseIzakayaSkinSubmitBtnGameObject");
			DaySceneClosetSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetSubPannel>.NativeClassPtr, 100667087);
			DaySceneClosetSubPannel.NativeMethodInfoPtr_ChangeToSkin_Private_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetSubPannel>.NativeClassPtr, 100667088);
			DaySceneClosetSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetSubPannel>.NativeClassPtr, 100667089);
			DaySceneClosetSubPannel.NativeMethodInfoPtr_UpdateVisual_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetSubPannel>.NativeClassPtr, 100667090);
			DaySceneClosetSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetSubPannel>.NativeClassPtr, 100667091);
			DaySceneClosetSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetSubPannel>.NativeClassPtr, 100667092);
			DaySceneClosetSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__7_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetSubPannel>.NativeClassPtr, 100667093);
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x000E5874 File Offset: 0x000E3A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59953, XrefRangeEnd = 59998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneClosetSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x000E58B0 File Offset: 0x000E3AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59998, XrefRangeEnd = 60003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid ChangeToSkin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetSubPannel.NativeMethodInfoPtr_ChangeToSkin_Private_UniTaskVoid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x000E58EC File Offset: 0x000E3AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60003, XrefRangeEnd = 60004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneClosetSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x000E5928 File Offset: 0x000E3B28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 60043, RefRangeEnd = 60045, XrefRangeStart = 60004, XrefRangeEnd = 60043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetSubPannel.NativeMethodInfoPtr_UpdateVisual_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x000E595C File Offset: 0x000E3B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneClosetSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x000E5998 File Offset: 0x000E3B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60045, XrefRangeEnd = 60048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneClosetSubPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneClosetSubPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x000E59D4 File Offset: 0x000E3BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60048, XrefRangeEnd = 60054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__7_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__7_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
		public DaySceneClosetSubPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x000E5A08 File Offset: 0x000E3C08
		// (set) Token: 0x06001518 RID: 5400 RVA: 0x0000D1C1 File Offset: 0x0000B3C1
		public unsafe GameObject SubmitText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel.NativeFieldInfoPtr_SubmitText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel.NativeFieldInfoPtr_SubmitText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x000E5A38 File Offset: 0x000E3C38
		// (set) Token: 0x0600151A RID: 5402 RVA: 0x0000D1E0 File Offset: 0x0000B3E0
		public unsafe GameObject Check
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel.NativeFieldInfoPtr_Check);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel.NativeFieldInfoPtr_Check), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x000E5A68 File Offset: 0x000E3C68
		// (set) Token: 0x0600151C RID: 5404 RVA: 0x0000D1FF File Offset: 0x0000B3FF
		public unsafe UIButtonSimple ChangeClothesBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel.NativeFieldInfoPtr_ChangeClothesBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel.NativeFieldInfoPtr_ChangeClothesBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x000E5A98 File Offset: 0x000E3C98
		// (set) Token: 0x0600151E RID: 5406 RVA: 0x0000D21E File Offset: 0x0000B41E
		public unsafe UIButtonToggle UseAtNightSubmitBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel.NativeFieldInfoPtr_UseAtNightSubmitBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel.NativeFieldInfoPtr_UseAtNightSubmitBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x000E5AC8 File Offset: 0x000E3CC8
		// (set) Token: 0x06001520 RID: 5408 RVA: 0x0000D23D File Offset: 0x0000B43D
		public unsafe UIButtonToggle UseIzakayaSkinSubmitBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel.NativeFieldInfoPtr_UseIzakayaSkinSubmitBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel.NativeFieldInfoPtr_UseIzakayaSkinSubmitBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x000E5AF8 File Offset: 0x000E3CF8
		// (set) Token: 0x06001522 RID: 5410 RVA: 0x0000D25C File Offset: 0x0000B45C
		public unsafe GameObject UseAtNightSubmitBtnGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel.NativeFieldInfoPtr_UseAtNightSubmitBtnGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel.NativeFieldInfoPtr_UseAtNightSubmitBtnGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x000E5B28 File Offset: 0x000E3D28
		// (set) Token: 0x06001524 RID: 5412 RVA: 0x0000D27B File Offset: 0x0000B47B
		public unsafe GameObject UseIzakayaSkinSubmitBtnGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel.NativeFieldInfoPtr_UseIzakayaSkinSubmitBtnGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel.NativeFieldInfoPtr_UseIzakayaSkinSubmitBtnGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E3C RID: 3644
		private static readonly IntPtr NativeFieldInfoPtr_SubmitText;

		// Token: 0x04000E3D RID: 3645
		private static readonly IntPtr NativeFieldInfoPtr_Check;

		// Token: 0x04000E3E RID: 3646
		private static readonly IntPtr NativeFieldInfoPtr_ChangeClothesBtn;

		// Token: 0x04000E3F RID: 3647
		private static readonly IntPtr NativeFieldInfoPtr_UseAtNightSubmitBtn;

		// Token: 0x04000E40 RID: 3648
		private static readonly IntPtr NativeFieldInfoPtr_UseIzakayaSkinSubmitBtn;

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeFieldInfoPtr_UseAtNightSubmitBtnGameObject;

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeFieldInfoPtr_UseIzakayaSkinSubmitBtnGameObject;

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeMethodInfoPtr_ChangeToSkin_Private_UniTaskVoid_0;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisual_Private_Void_0;

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__7_0_Private_Void_0;

		// Token: 0x02000623 RID: 1571
		[ObfuscatedName("DayScene.UI.DaySceneClosetSubPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060091AD RID: 37293 RVA: 0x00277ECC File Offset: 0x002760CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DaySceneClosetSubPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneClosetSubPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneClosetSubPannel.__c>.NativeClassPtr);
				DaySceneClosetSubPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetSubPannel.__c>.NativeClassPtr, "<>9");
				DaySceneClosetSubPannel.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetSubPannel.__c>.NativeClassPtr, "<>9__7_1");
				DaySceneClosetSubPannel.__c.NativeFieldInfoPtr___9__7_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetSubPannel.__c>.NativeClassPtr, "<>9__7_2");
				DaySceneClosetSubPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetSubPannel.__c>.NativeClassPtr, 100667095);
				DaySceneClosetSubPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__7_1_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetSubPannel.__c>.NativeClassPtr, 100667096);
				DaySceneClosetSubPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__7_2_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetSubPannel.__c>.NativeClassPtr, 100667097);
			}

			// Token: 0x060091AE RID: 37294 RVA: 0x00277F70 File Offset: 0x00276170
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneClosetSubPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetSubPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091AF RID: 37295 RVA: 0x00277FAC File Offset: 0x002761AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59917, XrefRangeEnd = 59925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__7_1(bool enable)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref enable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetSubPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__7_1_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091B0 RID: 37296 RVA: 0x00277FEC File Offset: 0x002761EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59925, XrefRangeEnd = 59933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__7_2(bool enable)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref enable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetSubPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__7_2_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091B1 RID: 37297 RVA: 0x0004EE8D File Offset: 0x0004D08D
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003099 RID: 12441
			// (get) Token: 0x060091B2 RID: 37298 RVA: 0x0027802C File Offset: 0x0027622C
			// (set) Token: 0x060091B3 RID: 37299 RVA: 0x0004EE96 File Offset: 0x0004D096
			public unsafe static DaySceneClosetSubPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneClosetSubPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneClosetSubPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneClosetSubPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700309A RID: 12442
			// (get) Token: 0x060091B4 RID: 37300 RVA: 0x00278054 File Offset: 0x00276254
			// (set) Token: 0x060091B5 RID: 37301 RVA: 0x0004EEA8 File Offset: 0x0004D0A8
			public unsafe static UnityAction<bool> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneClosetSubPannel.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneClosetSubPannel.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700309B RID: 12443
			// (get) Token: 0x060091B6 RID: 37302 RVA: 0x0027807C File Offset: 0x0027627C
			// (set) Token: 0x060091B7 RID: 37303 RVA: 0x0004EEBA File Offset: 0x0004D0BA
			public unsafe static UnityAction<bool> __9__7_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneClosetSubPannel.__c.NativeFieldInfoPtr___9__7_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneClosetSubPannel.__c.NativeFieldInfoPtr___9__7_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005EAA RID: 24234
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005EAB RID: 24235
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04005EAC RID: 24236
			private static readonly IntPtr NativeFieldInfoPtr___9__7_2;

			// Token: 0x04005EAD RID: 24237
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005EAE RID: 24238
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__7_1_Internal_Void_Boolean_0;

			// Token: 0x04005EAF RID: 24239
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__7_2_Internal_Void_Boolean_0;
		}

		// Token: 0x02000624 RID: 1572
		[ObfuscatedName("DayScene.UI.DaySceneClosetSubPannel+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x060091B8 RID: 37304 RVA: 0x002780A4 File Offset: 0x002762A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DaySceneClosetSubPannel.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneClosetSubPannel>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneClosetSubPannel.__c__DisplayClass8_0>.NativeClassPtr);
				DaySceneClosetSubPannel.__c__DisplayClass8_0.NativeFieldInfoPtr_clothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetSubPannel.__c__DisplayClass8_0>.NativeClassPtr, "clothes");
				DaySceneClosetSubPannel.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetSubPannel.__c__DisplayClass8_0>.NativeClassPtr, 100667098);
				DaySceneClosetSubPannel.__c__DisplayClass8_0.NativeMethodInfoPtr__ChangeToSkin_b__0_Internal_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetSubPannel.__c__DisplayClass8_0>.NativeClassPtr, 100667099);
			}

			// Token: 0x060091B9 RID: 37305 RVA: 0x0027810C File Offset: 0x0027630C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneClosetSubPannel.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetSubPannel.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091BA RID: 37306 RVA: 0x00278148 File Offset: 0x00276348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59933, XrefRangeEnd = 59937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask _ChangeToSkin_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetSubPannel.__c__DisplayClass8_0.NativeMethodInfoPtr__ChangeToSkin_b__0_Internal_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask(pointer);
			}

			// Token: 0x060091BB RID: 37307 RVA: 0x0004EECC File Offset: 0x0004D0CC
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700309C RID: 12444
			// (get) Token: 0x060091BC RID: 37308 RVA: 0x00278180 File Offset: 0x00276380
			// (set) Token: 0x060091BD RID: 37309 RVA: 0x0004EED5 File Offset: 0x0004D0D5
			public unsafe ClothesProfile.Clothes clothes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel.__c__DisplayClass8_0.NativeFieldInfoPtr_clothes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClothesProfile.Clothes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel.__c__DisplayClass8_0.NativeFieldInfoPtr_clothes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005EB0 RID: 24240
			private static readonly IntPtr NativeFieldInfoPtr_clothes;

			// Token: 0x04005EB1 RID: 24241
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005EB2 RID: 24242
			private static readonly IntPtr NativeMethodInfoPtr__ChangeToSkin_b__0_Internal_UniTask_0;
		}

		// Token: 0x02000625 RID: 1573
		[ObfuscatedName("DayScene.UI.DaySceneClosetSubPannel+<ChangeToSkin>d__8")]
		public sealed class _ChangeToSkin_d__8 : ValueType
		{
			// Token: 0x060091BE RID: 37310 RVA: 0x002781B0 File Offset: 0x002763B0
			// Note: this type is marked as 'beforefieldinit'.
			static _ChangeToSkin_d__8()
			{
				Il2CppClassPointerStore<DaySceneClosetSubPannel._ChangeToSkin_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneClosetSubPannel>.NativeClassPtr, "<ChangeToSkin>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneClosetSubPannel._ChangeToSkin_d__8>.NativeClassPtr);
				DaySceneClosetSubPannel._ChangeToSkin_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetSubPannel._ChangeToSkin_d__8>.NativeClassPtr, "<>1__state");
				DaySceneClosetSubPannel._ChangeToSkin_d__8.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetSubPannel._ChangeToSkin_d__8>.NativeClassPtr, "<>t__builder");
				DaySceneClosetSubPannel._ChangeToSkin_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetSubPannel._ChangeToSkin_d__8>.NativeClassPtr, "<>4__this");
				DaySceneClosetSubPannel._ChangeToSkin_d__8.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetSubPannel._ChangeToSkin_d__8>.NativeClassPtr, "<>u__1");
				DaySceneClosetSubPannel._ChangeToSkin_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetSubPannel._ChangeToSkin_d__8>.NativeClassPtr, 100667100);
				DaySceneClosetSubPannel._ChangeToSkin_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetSubPannel._ChangeToSkin_d__8>.NativeClassPtr, 100667101);
			}

			// Token: 0x060091BF RID: 37311 RVA: 0x00278254 File Offset: 0x00276454
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 59951, RefRangeEnd = 59953, XrefRangeStart = 59937, XrefRangeEnd = 59951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetSubPannel._ChangeToSkin_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091C0 RID: 37312 RVA: 0x0027828C File Offset: 0x0027648C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetSubPannel._ChangeToSkin_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091C1 RID: 37313 RVA: 0x0004EEF4 File Offset: 0x0004D0F4
			public _ChangeToSkin_d__8(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060091C2 RID: 37314 RVA: 0x0004EEFD File Offset: 0x0004D0FD
			public _ChangeToSkin_d__8() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneClosetSubPannel._ChangeToSkin_d__8>.NativeClassPtr))
			{
			}

			// Token: 0x1700309D RID: 12445
			// (get) Token: 0x060091C3 RID: 37315 RVA: 0x002782D4 File Offset: 0x002764D4
			// (set) Token: 0x060091C4 RID: 37316 RVA: 0x0004EF0F File Offset: 0x0004D10F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel._ChangeToSkin_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel._ChangeToSkin_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700309E RID: 12446
			// (get) Token: 0x060091C5 RID: 37317 RVA: 0x002782FC File Offset: 0x002764FC
			// (set) Token: 0x060091C6 RID: 37318 RVA: 0x0004EF2A File Offset: 0x0004D12A
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel._ChangeToSkin_d__8.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel._ChangeToSkin_d__8.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700309F RID: 12447
			// (get) Token: 0x060091C7 RID: 37319 RVA: 0x0027832C File Offset: 0x0027652C
			// (set) Token: 0x060091C8 RID: 37320 RVA: 0x0004EF58 File Offset: 0x0004D158
			public unsafe DaySceneClosetSubPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel._ChangeToSkin_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneClosetSubPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel._ChangeToSkin_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030A0 RID: 12448
			// (get) Token: 0x060091C9 RID: 37321 RVA: 0x0027835C File Offset: 0x0027655C
			// (set) Token: 0x060091CA RID: 37322 RVA: 0x0004EF77 File Offset: 0x0004D177
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel._ChangeToSkin_d__8.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetSubPannel._ChangeToSkin_d__8.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005EB3 RID: 24243
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005EB4 RID: 24244
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005EB5 RID: 24245
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005EB6 RID: 24246
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005EB7 RID: 24247
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005EB8 RID: 24248
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
