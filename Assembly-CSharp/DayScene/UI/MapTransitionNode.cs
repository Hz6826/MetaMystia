using System;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace DayScene.UI
{
	// Token: 0x020000B8 RID: 184
	public class MapTransitionNode : MonoBehaviour
	{
		// Token: 0x06001404 RID: 5124 RVA: 0x000E1AB4 File Offset: 0x000DFCB4
		// Note: this type is marked as 'beforefieldinit'.
		static MapTransitionNode()
		{
			Il2CppClassPointerStore<MapTransitionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "MapTransitionNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapTransitionNode>.NativeClassPtr);
			MapTransitionNode.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTransitionNode>.NativeClassPtr, "key");
			MapTransitionNode.NativeFieldInfoPtr_costOneAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTransitionNode>.NativeClassPtr, "costOneAction");
			MapTransitionNode.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTransitionNode>.NativeClassPtr, "connections");
			MapTransitionNode.NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTransitionNode>.NativeClassPtr, "interactable");
			MapTransitionNode.NativeFieldInfoPtr_visualParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTransitionNode>.NativeClassPtr, "visualParent");
			MapTransitionNode.NativeFieldInfoPtr__YukariTeleportCost_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTransitionNode>.NativeClassPtr, "<YukariTeleportCost>k__BackingField");
			MapTransitionNode.NativeFieldInfoPtr__Cost_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTransitionNode>.NativeClassPtr, "<Cost>k__BackingField");
			MapTransitionNode.NativeMethodInfoPtr_get_YukariTeleportCost_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionNode>.NativeClassPtr, 100666768);
			MapTransitionNode.NativeMethodInfoPtr_set_YukariTeleportCost_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionNode>.NativeClassPtr, 100666769);
			MapTransitionNode.NativeMethodInfoPtr_get_Cost_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionNode>.NativeClassPtr, 100666770);
			MapTransitionNode.NativeMethodInfoPtr_set_Cost_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionNode>.NativeClassPtr, 100666771);
			MapTransitionNode.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionNode>.NativeClassPtr, 100666772);
			MapTransitionNode.NativeMethodInfoPtr_SetOff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionNode>.NativeClassPtr, 100666773);
			MapTransitionNode.NativeMethodInfoPtr_Initialize_Public_Boolean_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionNode>.NativeClassPtr, 100666774);
			MapTransitionNode.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionNode>.NativeClassPtr, 100666775);
			MapTransitionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionNode>.NativeClassPtr, 100666776);
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x000E1C24 File Offset: 0x000DFE24
		// (set) Token: 0x06001406 RID: 5126 RVA: 0x000E1C60 File Offset: 0x000DFE60
		public unsafe int YukariTeleportCost
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionNode.NativeMethodInfoPtr_get_YukariTeleportCost_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 55197, RefRangeEnd = 55206, XrefRangeStart = 55197, XrefRangeEnd = 55197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionNode.NativeMethodInfoPtr_set_YukariTeleportCost_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x000E1CA0 File Offset: 0x000DFEA0
		// (set) Token: 0x06001408 RID: 5128 RVA: 0x000E1CDC File Offset: 0x000DFEDC
		public unsafe int Cost
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionNode.NativeMethodInfoPtr_get_Cost_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionNode.NativeMethodInfoPtr_set_Cost_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x000E1D1C File Offset: 0x000DFF1C
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionNode.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x000E1D50 File Offset: 0x000DFF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55206, XrefRangeEnd = 55208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionNode.NativeMethodInfoPtr_SetOff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x000E1D84 File Offset: 0x000DFF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55208, XrefRangeEnd = 55227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Initialize(Action onHighlightAction, Action onEnterTravelConfimationCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onHighlightAction);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onEnterTravelConfimationCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionNode.NativeMethodInfoPtr_Initialize_Public_Boolean_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x000E1DE4 File Offset: 0x000DFFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55227, XrefRangeEnd = 55231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapTransitionNode.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x000E1E20 File Offset: 0x000E0020
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapTransitionNode() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapTransitionNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x0000C927 File Offset: 0x0000AB27
		public MapTransitionNode(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x000E1E5C File Offset: 0x000E005C
		// (set) Token: 0x06001410 RID: 5136 RVA: 0x0000C930 File Offset: 0x0000AB30
		public unsafe string key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionNode.NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionNode.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001411 RID: 5137 RVA: 0x000E1E84 File Offset: 0x000E0084
		// (set) Token: 0x06001412 RID: 5138 RVA: 0x0000C94F File Offset: 0x0000AB4F
		public unsafe bool costOneAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionNode.NativeFieldInfoPtr_costOneAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionNode.NativeFieldInfoPtr_costOneAction)) = value;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x000E1EAC File Offset: 0x000E00AC
		// (set) Token: 0x06001414 RID: 5140 RVA: 0x0000C96A File Offset: 0x0000AB6A
		public unsafe Il2CppReferenceArray<MapTransitionNode> connections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionNode.NativeFieldInfoPtr_connections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTransitionNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionNode.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x000E1EDC File Offset: 0x000E00DC
		// (set) Token: 0x06001416 RID: 5142 RVA: 0x0000C989 File Offset: 0x0000AB89
		public unsafe UIButtonSimple interactable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionNode.NativeFieldInfoPtr_interactable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionNode.NativeFieldInfoPtr_interactable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x000E1F0C File Offset: 0x000E010C
		// (set) Token: 0x06001418 RID: 5144 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
		public unsafe GameObject visualParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionNode.NativeFieldInfoPtr_visualParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionNode.NativeFieldInfoPtr_visualParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x000E1F3C File Offset: 0x000E013C
		// (set) Token: 0x0600141A RID: 5146 RVA: 0x0000C9C7 File Offset: 0x0000ABC7
		public unsafe int _YukariTeleportCost_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionNode.NativeFieldInfoPtr__YukariTeleportCost_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionNode.NativeFieldInfoPtr__YukariTeleportCost_k__BackingField)) = value;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x000E1F64 File Offset: 0x000E0164
		// (set) Token: 0x0600141C RID: 5148 RVA: 0x0000C9E2 File Offset: 0x0000ABE2
		public unsafe int _Cost_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionNode.NativeFieldInfoPtr__Cost_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionNode.NativeFieldInfoPtr__Cost_k__BackingField)) = value;
			}
		}

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeFieldInfoPtr_costOneAction;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeFieldInfoPtr_connections;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeFieldInfoPtr_interactable;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeFieldInfoPtr_visualParent;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeFieldInfoPtr__YukariTeleportCost_k__BackingField;

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeFieldInfoPtr__Cost_k__BackingField;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeMethodInfoPtr_get_YukariTeleportCost_Public_get_Int32_0;

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeMethodInfoPtr_set_YukariTeleportCost_Public_set_Void_Int32_0;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeMethodInfoPtr_get_Cost_Public_get_Int32_0;

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeMethodInfoPtr_set_Cost_Public_set_Void_Int32_0;

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeMethodInfoPtr_SetOff_Public_Void_0;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Boolean_Action_Action_0;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020005DF RID: 1503
		[ObfuscatedName("DayScene.UI.MapTransitionNode+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x06008E41 RID: 36417 RVA: 0x0026E5B8 File Offset: 0x0026C7B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<MapTransitionNode.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapTransitionNode>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapTransitionNode.__c__DisplayClass15_0>.NativeClassPtr);
				MapTransitionNode.__c__DisplayClass15_0.NativeFieldInfoPtr_onHighlightAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTransitionNode.__c__DisplayClass15_0>.NativeClassPtr, "onHighlightAction");
				MapTransitionNode.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionNode.__c__DisplayClass15_0>.NativeClassPtr, 100666777);
				MapTransitionNode.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionNode.__c__DisplayClass15_0>.NativeClassPtr, 100666778);
			}

			// Token: 0x06008E42 RID: 36418 RVA: 0x0026E620 File Offset: 0x0026C820
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapTransitionNode.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionNode.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008E43 RID: 36419 RVA: 0x0026E65C File Offset: 0x0026C85C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55196, XrefRangeEnd = 55197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionNode.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008E44 RID: 36420 RVA: 0x0004C96C File Offset: 0x0004AB6C
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F8D RID: 12173
			// (get) Token: 0x06008E45 RID: 36421 RVA: 0x0026E690 File Offset: 0x0026C890
			// (set) Token: 0x06008E46 RID: 36422 RVA: 0x0004C975 File Offset: 0x0004AB75
			public unsafe Action onHighlightAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionNode.__c__DisplayClass15_0.NativeFieldInfoPtr_onHighlightAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionNode.__c__DisplayClass15_0.NativeFieldInfoPtr_onHighlightAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005CE1 RID: 23777
			private static readonly IntPtr NativeFieldInfoPtr_onHighlightAction;

			// Token: 0x04005CE2 RID: 23778
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005CE3 RID: 23779
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;
		}
	}
}
