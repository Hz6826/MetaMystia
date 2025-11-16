using System;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;
using TMPro;
using UnityEngine;

namespace DayScene.UI
{
	// Token: 0x020000CC RID: 204
	public class DaySceneMapDescriber : MonoBehaviour
	{
		// Token: 0x06001898 RID: 6296 RVA: 0x000F03A0 File Offset: 0x000EE5A0
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneMapDescriber()
		{
			Il2CppClassPointerStore<DaySceneMapDescriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DaySceneMapDescriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneMapDescriber>.NativeClassPtr);
			DaySceneMapDescriber.NativeFieldInfoPtr_m_MapName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMapDescriber>.NativeClassPtr, "m_MapName");
			DaySceneMapDescriber.NativeFieldInfoPtr_m_MapDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMapDescriber>.NativeClassPtr, "m_MapDescription");
			DaySceneMapDescriber.NativeFieldInfoPtr_m_CollectablePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMapDescriber>.NativeClassPtr, "m_CollectablePrefab");
			DaySceneMapDescriber.NativeFieldInfoPtr_m_CollectableField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMapDescriber>.NativeClassPtr, "m_CollectableField");
			DaySceneMapDescriber.NativeFieldInfoPtr_m_CollectablePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMapDescriber>.NativeClassPtr, "m_CollectablePanel");
			DaySceneMapDescriber.NativeFieldInfoPtr_m_Collectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMapDescriber>.NativeClassPtr, "m_Collectables");
			DaySceneMapDescriber.NativeFieldInfoPtr_m_CollectablePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMapDescriber>.NativeClassPtr, "m_CollectablePool");
			DaySceneMapDescriber.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMapDescriber>.NativeClassPtr, 100667673);
			DaySceneMapDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMapDescriber>.NativeClassPtr, 100667674);
			DaySceneMapDescriber.NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMapDescriber>.NativeClassPtr, 100667675);
			DaySceneMapDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMapDescriber>.NativeClassPtr, 100667676);
			DaySceneMapDescriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMapDescriber>.NativeClassPtr, 100667677);
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x000F04C0 File Offset: 0x000EE6C0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 27675, RefRangeEnd = 27686, XrefRangeStart = 27675, XrefRangeEnd = 27686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMapDescriber.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x000F04F4 File Offset: 0x000EE6F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67162, RefRangeEnd = 67163, XrefRangeStart = 67088, XrefRangeEnd = 67162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Describe(string mapName, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMapDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x000F0550 File Offset: 0x000EE750
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DescribeNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMapDescriber.NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x000F0584 File Offset: 0x000EE784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67163, XrefRangeEnd = 67174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneMapDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x000F05C0 File Offset: 0x000EE7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67174, XrefRangeEnd = 67190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneMapDescriber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneMapDescriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMapDescriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x0000F542 File Offset: 0x0000D742
		public DaySceneMapDescriber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x0600189F RID: 6303 RVA: 0x000F05FC File Offset: 0x000EE7FC
		// (set) Token: 0x060018A0 RID: 6304 RVA: 0x0000F54B File Offset: 0x0000D74B
		public unsafe TextMeshProUGUI m_MapName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapDescriber.NativeFieldInfoPtr_m_MapName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapDescriber.NativeFieldInfoPtr_m_MapName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x060018A1 RID: 6305 RVA: 0x000F062C File Offset: 0x000EE82C
		// (set) Token: 0x060018A2 RID: 6306 RVA: 0x0000F56A File Offset: 0x0000D76A
		public unsafe TextMeshProUGUI m_MapDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapDescriber.NativeFieldInfoPtr_m_MapDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapDescriber.NativeFieldInfoPtr_m_MapDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x000F065C File Offset: 0x000EE85C
		// (set) Token: 0x060018A4 RID: 6308 RVA: 0x0000F589 File Offset: 0x0000D789
		public unsafe GameObject m_CollectablePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapDescriber.NativeFieldInfoPtr_m_CollectablePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapDescriber.NativeFieldInfoPtr_m_CollectablePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x000F068C File Offset: 0x000EE88C
		// (set) Token: 0x060018A6 RID: 6310 RVA: 0x0000F5A8 File Offset: 0x0000D7A8
		public unsafe RectTransform m_CollectableField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapDescriber.NativeFieldInfoPtr_m_CollectableField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapDescriber.NativeFieldInfoPtr_m_CollectableField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x000F06BC File Offset: 0x000EE8BC
		// (set) Token: 0x060018A8 RID: 6312 RVA: 0x0000F5C7 File Offset: 0x0000D7C7
		public unsafe GameObject m_CollectablePanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapDescriber.NativeFieldInfoPtr_m_CollectablePanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapDescriber.NativeFieldInfoPtr_m_CollectablePanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x000F06EC File Offset: 0x000EE8EC
		// (set) Token: 0x060018AA RID: 6314 RVA: 0x0000F5E6 File Offset: 0x0000D7E6
		public unsafe List<Sprite> m_Collectables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapDescriber.NativeFieldInfoPtr_m_Collectables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapDescriber.NativeFieldInfoPtr_m_Collectables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x000F071C File Offset: 0x000EE91C
		// (set) Token: 0x060018AC RID: 6316 RVA: 0x0000F605 File Offset: 0x0000D805
		public unsafe List<GameObject> m_CollectablePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapDescriber.NativeFieldInfoPtr_m_CollectablePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapDescriber.NativeFieldInfoPtr_m_CollectablePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeFieldInfoPtr_m_MapName;

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeFieldInfoPtr_m_MapDescription;

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeFieldInfoPtr_m_CollectablePrefab;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeFieldInfoPtr_m_CollectableField;

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeFieldInfoPtr_m_CollectablePanel;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeFieldInfoPtr_m_Collectables;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeFieldInfoPtr_m_CollectablePool;

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_String_CancellationToken_0;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000675 RID: 1653
		[ObfuscatedName("DayScene.UI.DaySceneMapDescriber+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600955D RID: 38237 RVA: 0x00282F40 File Offset: 0x00281140
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DaySceneMapDescriber.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneMapDescriber>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneMapDescriber.__c>.NativeClassPtr);
				DaySceneMapDescriber.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMapDescriber.__c>.NativeClassPtr, "<>9");
				DaySceneMapDescriber.__c.NativeFieldInfoPtr___9__8_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMapDescriber.__c>.NativeClassPtr, "<>9__8_2");
				DaySceneMapDescriber.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMapDescriber.__c>.NativeClassPtr, "<>9__8_1");
				DaySceneMapDescriber.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMapDescriber.__c>.NativeClassPtr, "<>9__8_0");
				DaySceneMapDescriber.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMapDescriber.__c>.NativeClassPtr, 100667679);
				DaySceneMapDescriber.__c.NativeMethodInfoPtr__Describe_b__8_1_Internal_IEnumerable_1_Sprite_Collectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMapDescriber.__c>.NativeClassPtr, 100667680);
				DaySceneMapDescriber.__c.NativeMethodInfoPtr__Describe_b__8_2_Internal_Sprite_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMapDescriber.__c>.NativeClassPtr, 100667681);
				DaySceneMapDescriber.__c.NativeMethodInfoPtr__Describe_b__8_0_Internal_Void_UIElementCluster_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMapDescriber.__c>.NativeClassPtr, 100667682);
			}

			// Token: 0x0600955E RID: 38238 RVA: 0x0028300C File Offset: 0x0028120C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneMapDescriber.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMapDescriber.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600955F RID: 38239 RVA: 0x00283048 File Offset: 0x00281248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67065, XrefRangeEnd = 67084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Sprite> _Describe_b__8_1(Collectable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMapDescriber.__c.NativeMethodInfoPtr__Describe_b__8_1_Internal_IEnumerable_1_Sprite_Collectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Sprite>>(intPtr3) : null;
			}

			// Token: 0x06009560 RID: 38240 RVA: 0x002830A0 File Offset: 0x002812A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67084, XrefRangeEnd = 67085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sprite _Describe_b__8_2(Product y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMapDescriber.__c.NativeMethodInfoPtr__Describe_b__8_2_Internal_Sprite_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}

			// Token: 0x06009561 RID: 38241 RVA: 0x002830F8 File Offset: 0x002812F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67085, XrefRangeEnd = 67088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__8_0(UIElementCluster ui, Sprite visual)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(visual);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMapDescriber.__c.NativeMethodInfoPtr__Describe_b__8_0_Internal_Void_UIElementCluster_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009562 RID: 38242 RVA: 0x00050C63 File Offset: 0x0004EE63
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170031A0 RID: 12704
			// (get) Token: 0x06009563 RID: 38243 RVA: 0x0028314C File Offset: 0x0028134C
			// (set) Token: 0x06009564 RID: 38244 RVA: 0x00050C6C File Offset: 0x0004EE6C
			public unsafe static DaySceneMapDescriber.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneMapDescriber.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneMapDescriber.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneMapDescriber.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031A1 RID: 12705
			// (get) Token: 0x06009565 RID: 38245 RVA: 0x00283174 File Offset: 0x00281374
			// (set) Token: 0x06009566 RID: 38246 RVA: 0x00050C7E File Offset: 0x0004EE7E
			public unsafe static Func<Product, Sprite> __9__8_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneMapDescriber.__c.NativeFieldInfoPtr___9__8_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, Sprite>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneMapDescriber.__c.NativeFieldInfoPtr___9__8_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031A2 RID: 12706
			// (get) Token: 0x06009567 RID: 38247 RVA: 0x0028319C File Offset: 0x0028139C
			// (set) Token: 0x06009568 RID: 38248 RVA: 0x00050C90 File Offset: 0x0004EE90
			public unsafe static Func<Collectable, IEnumerable<Sprite>> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneMapDescriber.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Collectable, IEnumerable<Sprite>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneMapDescriber.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031A3 RID: 12707
			// (get) Token: 0x06009569 RID: 38249 RVA: 0x002831C4 File Offset: 0x002813C4
			// (set) Token: 0x0600956A RID: 38250 RVA: 0x00050CA2 File Offset: 0x0004EEA2
			public unsafe static Action<UIElementCluster, Sprite> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneMapDescriber.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster, Sprite>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneMapDescriber.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040060E9 RID: 24809
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040060EA RID: 24810
			private static readonly IntPtr NativeFieldInfoPtr___9__8_2;

			// Token: 0x040060EB RID: 24811
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x040060EC RID: 24812
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040060ED RID: 24813
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040060EE RID: 24814
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__8_1_Internal_IEnumerable_1_Sprite_Collectable_0;

			// Token: 0x040060EF RID: 24815
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__8_2_Internal_Sprite_Product_0;

			// Token: 0x040060F0 RID: 24816
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__8_0_Internal_Void_UIElementCluster_Sprite_0;
		}
	}
}
